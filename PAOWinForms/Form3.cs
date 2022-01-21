// This is an independent project of an individual developer. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com/

using PAOCore;
using System.Windows.Forms;

namespace PAOWinForms
{
    public partial class Form3 : Form
    {
        #region Public and private fields and properties

        public DataHelper Data { get; private set; } = DataHelper.Instance;

        #endregion

        #region Constructor and destructor

        public Form3()
        {
            InitializeComponent();
        }

        #endregion
    }
}
