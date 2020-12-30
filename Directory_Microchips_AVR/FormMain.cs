using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Directory_Microchips_AVR
{
    public partial class FormMain : Form
    {
        DB db = new DB();
        Button buttonSave;
        bool tableIsFull = false;
        bool informationSaved = false;
        public FormMain()
        {
            InitializeComponent();
            buttonTablesClicker();
            StandartFormSettings standartForm = new StandartFormSettings(this);
            this.BackColor = Color.FromArgb(255, 255, 255);
            panelMain.BackColor = Color.FromArgb(255, 255, 255);
            panelMain.Location = new Point(300, 40);
            panelMain.Size = new Size(this.Width - (this.Width - 1320), this.Height - (this.Height - 994));
        }
        private void buttonSaveCreator()
        {
            buttonSave = new Button();
            buttonSave.BackColor = Color.Teal;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold);
            buttonSave.ForeColor =Color.White;
            buttonSave.Location = new Point(400, 25);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(250, 50);
            buttonSave.TabIndex = 71;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = false;
            panelDataTable.Controls.Add(buttonSave);
        }
        private void tableDataFiller(string comand,string nameTable)
        {
            if (tableIsFull == true && informationSaved==false)
            {
                DialogResult result = MessageBox.Show("All changes that were not saved will disappear\nDONT save information?","WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    informationSaved=true;
                else 
                    return;
            }
            buttonSaveCreator();
            panelDataTable.Visible = true;
            panelDataTable.Location = new Point(294, 150);
            panelDataTable.Size = new Size(1026, 850);
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(comand, db.GetConnection());
                DataSet ds = new DataSet();
                adapter.Fill(ds, nameTable);
                dataGridView.DataSource = ds.Tables[0];
                buttonSave.MouseClick += (s, e) => buttonSaveMouseClick(ds, adapter, nameTable);
                tableIsFull = true;
                informationSaved = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void buttonTablesClicker()
        {
            //duttonMicrochipsAVR.MouseClick += (s, e) => tableDataFiller("SELECT * FROM `microcontroller_avr`", "microcontroller_avr");
            duttonMicrochipsAVR.MouseClick += (s, e) => tableDataFiller(
                "SELECT m.microcontroller_avr_ID,m.microcontroller_avr_name,m.program_memory, m.external_RAM,m.number_of_commands,m.number_of_inputs_outputs,m.working_arequency,m.supply_voltage_V," +
                "m.corpus_ID, c.name, c.number_of_legs," +
                "m.interfaces_ID, i.name, i.number_of_interfaces," +
                "m.data_memory_ID, d.name, d.number_of_bytes," +
                "m.timer_ID, t.name, t.number_of_timers" +
                " FROM  microcontroller_avr m" +
                "  INNER JOIN corpus c ON m.corpus_ID = c.corpus_ID" +
                "  INNER JOIN interfaces i ON m.interfaces_ID = i.interfaces_ID" +
                "  INNER JOIN data_memory d ON m.data_memory_ID = d.data_memory_ID" +
                "  INNER JOIN timer t ON m.timer_ID = t.timer_ID", "microcontroller_avr");
            buttonCorpuses.MouseClick += (s, e) => tableDataFiller("SELECT * FROM `corpus`", "corpus");
            buttonDataMemories.MouseClick += (s, e) => tableDataFiller("SELECT * FROM `data_memory`", "data_memory");
            buttonInterfaces.MouseClick += (s, e) => tableDataFiller("SELECT * FROM `interfaces`","interfaces");
            buttonTimers.MouseClick += (s, e) => tableDataFiller("SELECT * FROM `timer`", "timer");
            buttonProjects.MouseClick += (s, e) => tableDataFiller("" +
                "SELECT p.project_ID,p.Name,p.settings,p.description,p.microcontroller_avr_ID," +
                "m.microcontroller_avr_name, m.program_memory, m.external_RAM, m.working_arequency" +
                " FROM project p" +
                "  INNER JOIN microcontroller_avr m ON p.microcontroller_avr_ID = m.microcontroller_avr_ID", "project");
        }

        private void buttonTableCatalog_Click(object sender, EventArgs e)
        {
            if (panelCatalog.Visible == true)
                panelCatalog.Visible = false;
            else
                panelCatalog.Visible = true;
        }

        private void buttonSaveMouseClick(DataSet dataSet,MySqlDataAdapter adapter,string nameTable)
        {
            
            FormSave formSave = new FormSave();
            DialogResult result;
            while (true)
            {
                result = formSave.ShowDialog(this);

                if (result == DialogResult.No)
                    return;
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        MySqlCommandBuilder comandBilder = new MySqlCommandBuilder(adapter);
                        adapter.Update(dataSet, nameTable);
                        MessageBox.Show("Informations update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        informationSaved = true;
                        buttonSave.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                return;
            }
        }
    }
}
