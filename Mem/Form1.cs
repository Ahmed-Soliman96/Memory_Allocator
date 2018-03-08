using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mem
{
    public partial class MemoryAllocator : Form
    {
        int Capacity = 1000, count = 0, flag = 0;
        List<Process> processes = new List<Process>();
        List<bool> oversize = new List<bool>();
        Process p = new Process();
        List<Hole> holes = new List<Hole>();
        Hole h = new Hole();
        List<Hole> Allholes = new List<Hole>();
        char type;
        bool notFound = true;

        public MemoryAllocator()
        {
            InitializeComponent();
            //Reset_button.Enabled = false;
            Allocation_button.Enabled = false;
            Deallocation_button.Enabled = false;
            PID.Enabled = false;
            Size.Enabled = false;
            First_fit.Enabled = false;
            Best_fit.Enabled = false;
            Worst_fit.Enabled = false;
        }

        private void MemoryAllocator_Load(object sender, EventArgs e){}

        private void Hole_size_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) //Hole size
        {}

        private void Hole_address_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) //Hole address
        {}

        private void radioButton1_CheckedChanged(object sender, EventArgs e)//Fisrt-Fit
        {
            type = 'F';
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//Best-Fit
        {
            type = 'B';
        }
        private void Worst_fit_CheckedChanged(object sender, EventArgs e)//Worst-fit
        {
            type = 'W';
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //PID
        {}

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) //Size
        {}

        private void Add_hole_Click(object sender, EventArgs e) //Insert holes button
        {
            if ((Hole_size.Text == "") || (Hole_address.Text == "") || (int.Parse(Hole_address.Text) >= Capacity) || (int.Parse(Hole_size.Text) >= Capacity) || ((int.Parse(Hole_address.Text) + int.Parse(Hole_size.Text))>=Capacity))
                MessageBox.Show("Enter the hole's suitble Size and Address");
            else
            {
                h = new Hole(int.Parse(Hole_address.Text), int.Parse(Hole_size.Text));
                holes.Add(h);
                holes = holes.OrderBy(x => x.address).ToList();
                InsertHoles(holes);
                Hole_size.Clear(); Hole_size.Focus();
                Hole_address.Clear(); Hole_address.Focus();
            }
        }

        private void Start_button_Click(object sender, EventArgs e) //START button
        {
            Reset_button.Enabled = true;
            Hole_size.Enabled = false;
            Hole_address.Enabled = false;
            Add_hole.Enabled = false;
            Start_button.Enabled = false;
            Allocation_button.Enabled = true;
            Deallocation_button.Enabled = true;
            PID.Enabled = true;
            Size.Enabled = true;
            First_fit.Enabled = true;
            Best_fit.Enabled = true;
            Worst_fit.Enabled = true;
            Capacity = 1000;
        }

        private void Reset_button_Click(object sender, EventArgs e) //RESET
        {
            //Reset_button.Enabled = false;
            Hole_size.Enabled = true;
            Hole_address.Enabled = true;
            Add_hole.Enabled = true;
            Start_button.Enabled = true;
            Allocation_button.Enabled = false;
            Deallocation_button.Enabled = false;
            PID.Enabled = false; PID.Clear(); PID.Focus();
            Size.Enabled = false; Size.Clear(); Size.Focus();
            First_fit.Enabled = false; First_fit.Checked = false;
            Best_fit.Enabled = false; Best_fit.Checked = false;
            Worst_fit.Enabled = false; Worst_fit.Checked = false;
            processes.Clear();
            holes.Clear();
            this.Holes_view.Rows.Clear();
            this.Memory_view.Rows.Clear();
            Capacity = 1000;
        }

        private void Memory_view_CellContentClick(object sender, DataGridViewCellEventArgs e) //Holes
        {}

        private void Memory_view_CellContentClick_1(object sender, DataGridViewCellEventArgs e) //Memory
        {}

        private void Memory_view_box_Enter(object sender, EventArgs e) {}

        private void Holes_view_box_Enter(object sender, EventArgs e)  {}

        private void button1_Click(object sender, EventArgs e) //Allocate
        {
            if ((PID.Text == "") || (Size.Text == "") || ((First_fit.Checked == false) && (Best_fit.Checked == false) && (Worst_fit.Checked == false)))
                MessageBox.Show("Enter the process's Info. or Choose an Allocation Method");
            else
            {
                if (int.Parse(Size.Text) >= Capacity) MessageBox.Show("No enough space");
                else
                {
                    p = new Process(PID.Text, int.Parse(Size.Text));
                    bool v = true;
                    oversize.Add(v);
                    processes.Add(p);
                    PID.Clear(); PID.Focus();
                    Size.Clear(); Size.Focus();
                    Allocate(p.size);
                    First_fit.Checked = false;
                    Best_fit.Checked = false;
                    Worst_fit.Checked = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) //Deallocate
        {
            if ((PID.Text == "") || (flag == 0))
                MessageBox.Show("Choose an allocated process to be Removed");
            else
            {
                for (int i = 0; i < processes.Count; i++)
                {
                    if (processes[i].name == PID.Text)
                    {
                        Deallocate(processes[i]);
                        processes.RemoveAt(i);
                        notFound = false;
                        PID.Clear(); PID.Focus();
                        break;
                    }
                }
                if (notFound == true) MessageBox.Show("Wrong process ID");
            }
        }
        //
        private void InsertHoles(List<Hole> AddedHoles) //Insert Holes
        {
            this.Holes_view.Rows.Clear();
            for (int i = 0; i < AddedHoles.Count(); i++)
            {
                Capacity = Capacity - (holes[i].size);
                this.Holes_view.Rows.Add();
                this.Holes_view.Rows[i].Cells[0].Value = holes[i].address; //Address
                this.Holes_view.Rows[i].Cells[1].Value = holes[i].size; //Size
            }
        }

        private void Allocate(int Size)
        {
            switch (type)
            {
                case 'F': FirstFit(Size);
                    break;
                case 'B': BestFit(Size);
                    break;
                case 'W': WorstFit(Size);
                    break;
            }
        }

        private void FirstFit(int Size) //fn.
        {
            if (holes.Count() == 0) flag = 0;
            for (int i = 0; i < holes.Count(); i++)
            {
                if (Size <= holes[i].size)
                {
                    flag = 1;
                    this.Memory_view.Rows.Add();
                    this.Memory_view.Rows[count].Cells[0].Value = flag; //Flag
                    this.Memory_view.Rows[count].Cells[1].Value = "P" + count;//PID
                    this.Memory_view.Rows[count].Cells[2].Value = holes[i].address; //Address
                    p.address = holes[i].address;
                    this.Memory_view.Rows[count].Cells[3].Value = Size; //Size
                    if (Size < holes[i].size)
                    {
                        h = new Hole((holes[i].address + Size), (holes[i].size - Size));
                        holes.Add(h);
                    }
                    Allholes.Add(holes[i]);
                    holes.RemoveAt(i);
                    holes = holes.OrderBy(x => x.address).ToList();
                    InsertHoles(holes);
                    oversize[count] = false;
                    count++;
                    break;
                }
            }
            if (oversize[oversize.Count - 1] == true)
            {
                this.Memory_view.Rows.Add();
                flag = 0;
                this.Memory_view.Rows[count].Cells[0].Value = flag; //Flag
                this.Memory_view.Rows[count].Cells[1].Value = "P" + count;//PID
                this.Memory_view.Rows[count].Cells[2].Value = "Not allocated"; //Address
                this.Memory_view.Rows[count].Cells[3].Value = Size; //Size
            }
        }
        private void BestFit(int Size) //fn.
        {
            if (holes.Count() == 0) flag = 0;
            for (int i = 0; i < holes.Count(); i++)
            {
                if (Size <= holes[i].size)
                {
                    flag = 1;
                    holes = holes.OrderBy(x => x.size).ToList();
                    this.Memory_view.Rows.Add();
                    this.Memory_view.Rows[count].Cells[0].Value = flag; //Flag
                    this.Memory_view.Rows[count].Cells[1].Value = "P" + count;//PID
                    this.Memory_view.Rows[count].Cells[2].Value = holes[i].address; //Address
                    p.address = holes[i].address;
                    this.Memory_view.Rows[count].Cells[3].Value = Size; //Size
                    if (Size < holes[i].size)
                    {
                        h = new Hole((holes[i].address + Size), (holes[i].size - Size));
                        holes.Add(h);
                    }
                    Allholes.Add(holes[i]);
                    holes.RemoveAt(i);
                    holes = holes.OrderBy(x => x.address).ToList();
                    InsertHoles(holes);
                    oversize[count] = false;
                    count++;
                    break;
                }
            }
            if (oversize[oversize.Count-1] == true)
            {
                this.Memory_view.Rows.Add();
                flag = 0;
                this.Memory_view.Rows[count].Cells[0].Value = flag; //Flag
                this.Memory_view.Rows[count].Cells[1].Value = "P" + count;//PID
                this.Memory_view.Rows[count].Cells[2].Value = "Not allocated"; //Address
                this.Memory_view.Rows[count].Cells[3].Value = Size; //Size
            }
        }
        private void WorstFit(int Size) //fn.
        {
            if (holes.Count() == 0) flag = 0;
            for (int i = 0; i < holes.Count(); i++)
            {
                holes = holes.OrderBy(x => x.size).ToList();
                holes.Reverse();
                if (Size <= holes[i].size)
                {
                    flag = 1;
                    this.Memory_view.Rows.Add();
                    this.Memory_view.Rows[count].Cells[0].Value = flag; //Flag
                    this.Memory_view.Rows[count].Cells[1].Value = "P" + count;//PID
                    this.Memory_view.Rows[count].Cells[2].Value = holes[i].address; //Address
                    p.address = holes[i].address;
                    this.Memory_view.Rows[count].Cells[3].Value = Size; //Size
                    if (Size < holes[i].size)
                    {
                        h = new Hole((holes[i].address + Size), (holes[i].size - Size));
                        holes.Add(h);
                    }
                    Allholes.Add(holes[i]);
                    holes.RemoveAt(i);
                    holes.Reverse();
                    holes = holes.OrderBy(x => x.address).ToList();
                    InsertHoles(holes);
                    oversize[count] = false;
                    count++;
                    break;
                }
            }
            if (oversize[oversize.Count - 1] == true)
            {
                this.Memory_view.Rows.Add();
                flag = 0;
                this.Memory_view.Rows[count].Cells[0].Value = flag; //Flag
                this.Memory_view.Rows[count].Cells[1].Value = "P" + count;//PID
                this.Memory_view.Rows[count].Cells[2].Value = "Not allocated"; //Address
                this.Memory_view.Rows[count].Cells[3].Value = Size; //Size
            }
        }

        private void Deallocate(Process C) //fn.
        {
            //h = new Hole(holes[count - 1].address+15, C.size);
            h = new Hole((Allholes.Find(x => x.address == C.address).address), C.size);
            holes.Add(h);
            holes = holes.OrderBy(x => x.address).ToList();
            for (int i = 1; i < holes.Count(); i++)
            {
                if (((holes[i - 1].size) + holes[i - 1].address) == holes[i].address)
                {
                    holes[i - 1].size += holes[i].size;
                    holes.RemoveAt(i);
                }
            }
            InsertHoles(holes);
            for (int j = 0; j < this.Memory_view.RowCount; j++)
            {
                string pidTxt = PID.Text;
                string memView = Memory_view.Rows[j].Cells[1].Value.ToString();
                if (pidTxt == memView)
                {
                    Memory_view.Rows.RemoveAt(j);
                    break;
                }
            }
        }
}

    class Process
    {
        public string name;
        public int size, address;

        public Process() { }
        public Process(string name, int size)
        {
            this.name = name;
            this.size = size;
            this.address = address;
        }
    }
    class Hole
    {
        public int size, address;

        public Hole() { }
        public Hole(int address, int size)
        {
            this.address = address;
            this.size = size;
        }
    }

}