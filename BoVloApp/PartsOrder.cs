using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoVloApp
{
    public partial class PartsOrder : Form
    {
        public PartsOrder()
        {
            InitializeComponent();
            dataPiece.DataSource = getPiece();
        }

        private DataTable getPiece()
        {
            string request = "SELECT Piece.NamePiece " +
                "FROM Piece ";
            DataTable piece = Program.ReadSQL(request);
            
            piece.Columns.Add("Quantity", typeof(String));
            piece.Columns["NamePiece"].ColumnName = "Name";

            return piece;

        }


    }
}
