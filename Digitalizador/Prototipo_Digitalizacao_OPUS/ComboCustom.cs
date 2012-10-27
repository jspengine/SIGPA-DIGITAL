using System;

namespace DigitalView
{
    //public class ComboCustom : Nevron.UI.WinForm.Controls.NListBoxItem 
    public class ComboCustom : System.Windows.Forms.ListViewItem
    {
        private object rotulo;
        private object valor;

        public ComboCustom(object pDblId, object pStrName )
        {
            base.Text = pStrName.ToString();
            Rotulo = pStrName;
            Valor = pDblId;
        }

        public object Rotulo
        {
            get { return rotulo; }
            set { rotulo = value; }
        }
        
        public object Valor
        {
            get { return valor; }
            set { valor = value; }
        }

    }
}
