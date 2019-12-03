using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Apresentacao
{
    public class ItemCombo
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }

        public ItemCombo(string text, object value)
        {
            Text = text;
            Value = value;
        }
    }
}
