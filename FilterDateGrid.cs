using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ETicaretDesktopAdmin.Resources.ToolsScript
{
    public partial class FilterDatagrid : UserControl
    {
        private readonly DataTable _dataTable;
        public FilterDatagrid(DataTable dataTable)
        {
            //İki Tane Datagirid var birinin kolonları gözükmüyor Kayıt satırı için 3. bir datagrid Eklenebilir
            InitializeComponent();
            foreach (DataColumn dr in dataTable.Columns)
            {
                _dataTable.Columns.Add(dr);
            }

            dataGridTop.DataSource = _dataTable;
            dataGrid.DataSource = dataTable;
        }
    }
}
