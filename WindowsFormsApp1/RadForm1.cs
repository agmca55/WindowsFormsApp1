using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace WindowsFormsApp1
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        DataSet dtSet;
        public RadForm1()
        {
            InitializeComponent();
            radGridView1.DataSource = Model.EmployeeModel.getEmployee();
            var checkBoxColumn = radGridView1.Columns[0] as GridViewCheckBoxColumn;
            checkBoxColumn.EnableHeaderCheckBox = true;
            checkBoxColumn.ShouldCheckDataRows = false;
            // checkBoxColumn.ReadOnly = true;
            radGridView1.HeaderCellToggleStateChanged += radGridView1_HeaderCellToggleStateChanged;
        }

        private void radGridView1_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {

            if (e.CellElement.ColumnInfo.Name == "age")
            {
                if (Convert.ToInt32(e.CellElement.Value) > 50)
                {
                    e.CellElement.ForeColor = Color.Black;
                    e.CellElement.BackColor = Color.Red;
                    e.CellElement.GradientStyle = GradientStyles.Solid;
                    e.CellElement.DrawFill = true;

                }
                else
                {
                }


            }
            else
            {
                if (e.CellElement.ColumnInfo.Name == "Status")
                {
                    //e.CellElement.Value = "Active";
                }
                else
                {
                    //   e.CellElement.Value = "In Active";
                }
                // e.CellElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local);
            }

        }

        private void rbtnSelectDeselect_Click(object sender, EventArgs e)
        {
            IList<GridViewRowInfo> gridRows = new List<GridViewRowInfo>();
            foreach (GridViewRowInfo rowInfo in radGridView1.ChildRows)
            {
                if (rowInfo.Cells["Select"].Value != null)
                {
                    bool isChecked = (bool)rowInfo.Cells["Select"].Value;
                    if (isChecked == true)
                    {
                        gridRows.Add(rowInfo);
                    }
                }

            }
            // this.radGridView2.GridViewElement.BeginEditMode();
            //this.radGridView2.GridElement.EndUpdate();

        }

        private void radGridView1_HeaderCellToggleStateChanged(object sender, GridViewHeaderCellEventArgs e)
        {
            foreach (GridViewDataRowInfo row in radGridView1.Rows)
            {
                if (row.Cells[row.Index].Value != null && (bool)row.Cells[row.Index].Value == true)
                {
                    var value = (int)row.Cells[row.Index].Value;
                    if (value < 50)
                    {
                        row.Cells[row.Index].Value = !(bool)row.Cells[3].Value;
                    }
                }

            }
        }

        private void radGridView1_ValueChanged(object sender, EventArgs e)
        {
            RadCheckBoxEditor editor = sender as RadCheckBoxEditor;
            if (editor != null)
            {
                this.radGridView1.EditorManager.EndEdit();
               
            }

        }
    } 
    }

