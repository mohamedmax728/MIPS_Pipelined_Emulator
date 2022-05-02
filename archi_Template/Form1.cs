using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archi_Template
{
    public partial class Form1 : Form
    {
        public int pc = 1000;
        public int pop = 0;
        public Hashtable Inst_mem = new Hashtable();
        public Hashtable dt_mem = new Hashtable();
        public int[] reg = new int[32];

        public Queue dcodequeue = new Queue();
        public Queue exqueue = new Queue();
        public Queue mmqueue = new Queue();
        public Queue wbqueue = new Queue();
        public Int64 wb;
        public int register1, register2;
        public string contit(string op)
        {
            string regds = "", alop1 = "", alop2 = "", ALUsrc = "", meread = "", mewrite = "", branch = "", regwri = "", metoreg = "";
            string e, me, w;
            if (op == "000000")
            {
                regds = "1";
                alop1 = "1";
                alop2 = "0";
                ALUsrc = "0";
                meread = "0";
                mewrite = "0";
                branch = "0";
                regwri = "1";
                metoreg = "0";
            }
            else if (op == "100011")
            {
                regds = "0";
                alop1 = "0";
                alop2 = "0";
                ALUsrc = "1";
                meread = "1";
                mewrite = "0";
                branch = "0";
                regwri = "1";
                metoreg = "1";
            }
            e = regds + alop1 + alop2 + ALUsrc;
            me = meread + mewrite + branch;
            w = regwri + metoreg;
            return e + me + w;
        }
        public void instructionmemory(string pccor, string inst)
        {
            Inst_mem.Add(pccor, inst);
        }
        public void register_file(int redr1, int redr2, int writere, int wrdate, int rwrite)
        {

            if (rwrite == 0)
            {
                register1 = reg[redr1];
                register2 = reg[redr2];
            }
            else
            {
                reg[writere] = wrdate;
            }
        }
        public Hashtable dame = new Hashtable();

        public Int64 aluoregis(Int64 d1, Int64 d2, string al, string funcode)
        {
            if (al == "00")
                return d1 + d2;
            else
            {
                if (funcode == "100000")
                {
                    return d1 + d2;
                }
                else if (funcode == "100010")
                {
                    return d1 - d2;
                }
                else if (funcode == "100100")
                {
                    return d1 & d2;
                }
                else
                {
                    return d1 | d2;
                }
            }

        }
        public object data_memory(int address, int write_d, int m_write, int m_read)
        {
            if (m_read == 1)
            {
                return dame[address];
            }
            if (m_write == 1)
            {
                dame[address] = write_d;
            }
            return null;
        }
        public Int64 mu(Int64 s1, Int64 s2, int select)
        {
            if (select == 0)
                return s1;
            else return s2;
        }
        public Int64 signExt(Int64 adddddd)
        {
            Int64 value = (0x0000FFFF & adddddd);
            Int64 mak = 0x00008000;
            Int64 signsda = (mak & adddddd) >> 15;
            if (signsda == 1)
                value += 0xFFFF0000;
            return value;
        }

        public void fetch()
        {
            string If_id;
            pc += 4;
            If_id = pc.ToString() + ":" + Inst_mem[(pc - 4).ToString()];
            dcodequeue.Enqueue(If_id.ToString());


        }

        public void decode()
        {

            string If_id = (string)dcodequeue.Dequeue();
            string[] part = If_id.Split(':');
            string opp = part[1].Substring(0, 6);
            string rs = "", rt = "", rd = "", shamt = "", fun = "", address = "";
            string cont = contit(opp);
            Int64 extended = 0;
            if (opp == "000000")
            {
                rs = part[1].Substring(6, 5);
                rt = part[1].Substring(11, 5);
                rd = part[1].Substring(16, 5);
                shamt = part[1].Substring(21, 5);
                fun = part[1].Substring(26, 6);

                register_file(Convert.ToInt32(rs, 2), Convert.ToInt32(rt, 2), 0, 0, 0);
                extended = signExt(Int64.Parse(rd + shamt + fun));
            }
            else if (opp == "100011")
            {
                rs = part[1].Substring(6, 5);
                rt = part[1].Substring(11, 5);
                address = part[1].Substring(16, 16);
                rd = part[1].Substring(16, 5);
                register_file(Convert.ToInt32(rs, 2), Convert.ToInt32(rt, 2), 0, 0, 0);
                extended = signExt(Int64.Parse(address));
            }
            string id_ex;
            id_ex = cont + ':' + part[0] + ':' + register1 + ':' + register2 + ':' + extended + ':' + rd + ':' + rt + ':' + part[1].Substring(26, 6);
            exqueue.Enqueue(id_ex);
        }

        public void exc()
        {
            string id_ex = (string)exqueue.Dequeue();
            string[] part = id_ex.Split(':');
            Int64 mualsource, mureg = 0;

            Int64 au = 0;
            string rt = part[6];
            string rd = part[5];

            if (part[0][0] == '1')
            {
                mualsource = mu(Int64.Parse(part[4]), Int64.Parse(part[3]), part[0][3]);
                string fun = part[7];
                au = aluoregis(Int64.Parse(part[2]), mualsource, "10", fun);
                mureg = mu(Convert.ToInt32(rt, 2), Convert.ToInt32(rd, 2), part[0][0]);

            }
            else if (part[0][0] == '0')
            {
                mualsource = mu(Int64.Parse(part[4]), Int64.Parse(part[3]), part[0][3]);
                au = aluoregis(register1, mualsource, "00", "0");
                mureg = mu(Convert.ToInt32(rt, 2), Convert.ToInt32(rd, 2), part[0][0]);
            }
            string ex_mem;
            ex_mem = part[0].Substring(4, 5) + ':' + au.ToString() + ':' + part[3] + ':' + mureg.ToString();
            mmqueue.Enqueue(ex_mem);

        }

        public void memorandwb()
        {

            string ex_mem = (string)mmqueue.Dequeue();
            string[] part = ex_mem.Split(':');
            string au = part[1];
            string mureg = part[3];
            int tmp = 0;
            //string opp = part[2];

            if (part[0][0] == '1')
            {
                tmp = (int)dt_mem[Int32.Parse(part[1])];
                // metorg = mu(Int64.Parse(au),99,1);
            }
            else if (part[0][1] == '1')
            {
                dt_mem[Int32.Parse(part[1])] = part[2];
                //metorg = mu(Int64.Parse(au), 99, 0);
            }
            string m = part[0].Substring(3, 2) + ':' + tmp.ToString() + ':' + part[1] + ':' + part[3];
            wbqueue.Enqueue(m);
        }

        public void writek()
        {
            string metorg = (string)wbqueue.Dequeue();
            string[] part = metorg.Split(':');
            string au = part[2];
            string mureg = part[3];
            int muout = 0;
            if (part[0][1] == '0')
            {
                muout = int.Parse(part[2]);
            }
            else if (part[0][1] == '1')
            {
                muout = int.Parse(part[1]);
            }

            if (part[0][0] == '1')
            {
                reg[int.Parse(part[3])] = muout;
            }

        }
        private void UserCodetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartPCTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MipsRegisterGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inializeBtn_Click(object sender, EventArgs e)
        {
            pc = int.Parse(StartPCTxt.Text);
            string s;
            for (int i = 0; i < UserCodetxt.Lines.Length; i++)
            {
                s = UserCodetxt.Lines[i];
                string[] part = s.Split(':');
                instructionmemory(part[0], part[1]);
                // fetch();
                // fetchqueue.Enqueue(If_id);
            }
            reg[0] = 0;
            for (int i = 1; i < 32; i++)
            {
                reg[i] = 100 + i;
            }
            for (int i = 0; i < 256; i++)
            {
                dt_mem[i] = 99;
            }
            MipsRegGrid.Rows.Add(32);
            for (int i = 0; i < 32; i++)
            {
                MipsRegGrid.Rows[i].Cells[0].Value = "$" + i.ToString();
                MipsRegGrid.Rows[i].Cells[1].Value = reg[i].ToString();

            }
            MemGrid.Rows.Add(256);

            for (int i = 0; i < 256; i++)
            {
                MemGrid.Rows[i].Cells[0].Value = i.ToString();
                MemGrid.Rows[i].Cells[1].Value = "99";
            }
        }

        private void MemoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int cy = 1;
        private void runCycleBtn_Click(object sender, EventArgs e)
        {
            do
            {
                foreach (DataGridViewRow row in PiplGrid.Rows)
                {
                    try
                    {
                        PiplGrid.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (PiplGrid.Rows.Count > 1);
            do
            {
                foreach (DataGridViewRow row in MipsRegGrid.Rows)
                {
                    try
                    {
                        MipsRegGrid.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (MipsRegGrid.Rows.Count > 1);
            do
            {
                foreach (DataGridViewRow row in MemGrid.Rows)
                {
                    try
                    {
                        MemGrid.Rows.Remove(row);
                    }
                    catch (Exception) { }
                }
            } while (MemGrid.Rows.Count > 1);
            if (wbqueue.Count > 0)
            {
                writek();

            }
            if (mmqueue.Count > 0)
            {
                memorandwb();
            }
            if (exqueue.Count > 0)
            {
                exc();
            }
            if (dcodequeue.Count > 0)
            {
                decode();
            }
            if (Inst_mem.ContainsKey(pc.ToString()))
            {
                fetch();
            }
            show();
        }
        void show()
        {

            //this.PiplGrid.Rows.Add("decode", "excute", "memory access", "write back");
            // this.PiplGrid.Rows.Insert(0, 0, 0, 0);
            if (wbqueue.Count > 0)
            {
                this.PiplGrid.Rows.Add("write back", wbqueue.Peek());
                // PiplGrid.Rows[3].Cells[1].Value = ;
                // PiplGrid.Rows[3].Cells[0].Value = "write back";
            }

            if (mmqueue.Count > 0)
            {
                this.PiplGrid.Rows.Add("memory access", mmqueue.Peek());
                //  PiplGrid.Rows[2].Cells[0].Value = "memory access";
                // PiplGrid.Rows[2].Cells[1].Value =;
            }
            if (exqueue.Count > 0)
            {
                this.PiplGrid.Rows.Add("excute", exqueue.Peek());
                // PiplGrid.Rows[1].Cells[0].Value = "excute";

            }
            if (dcodequeue.Count > 0)
            {
                this.PiplGrid.Rows.Add("decode", dcodequeue.Peek());
                //PiplGrid.Rows[0].Cells[0].Value = "decode";

            }





            MipsRegGrid.Rows.Add(32);
            for (int i = 0; i < 32; i++)
            {
                MipsRegGrid.Rows[i].Cells[0].Value = "$" + i.ToString();
                MipsRegGrid.Rows[i].Cells[1].Value = reg[i].ToString();

            }
            MemGrid.Rows.Add(256);

            for (int i = 0; i < 256; i++)
            {
                MemGrid.Rows[i].Cells[0].Value = i.ToString();
                MemGrid.Rows[i].Cells[1].Value = "99";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void PiplGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
