using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos_Final.Models
{
    public abstract class Action: Actionable  
    {
        public virtual void DeleteById(DataGridView dg)
        {
            throw new NotImplementedException();
        }

        public virtual void LoadingDataToDataGridView(DataGridView dg)
        {
            throw new NotImplementedException();
        }

        public virtual void Save()
        {
            throw new NotImplementedException();
        }

        public virtual void Search(DataGridView dg, string searchTerm)
        {
            throw new NotImplementedException();
        }

        public virtual void UpdateById(DataGridView dg)
        {
            throw new NotImplementedException();
        }
        public virtual void SearchByName(DataGridView dg)
        {
            throw new NotImplementedException();
        }
        public virtual void SearchById(DataGridView dg)
        {
            throw new NotImplementedException();
        }
    }
}
