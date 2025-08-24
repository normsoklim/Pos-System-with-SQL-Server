using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_Final.Models
{
    internal interface Actionable
    {
        void Save();
        void UpdateById(DataGridView dg);
        void DeleteById(DataGridView dg);
        void Search(DataGridView dg, string searchTerm);
        void SearchByName(DataGridView dg);
        void LoadingDataToDataGridView(DataGridView dg);
        void SearchById(DataGridView dg);
    }
}

