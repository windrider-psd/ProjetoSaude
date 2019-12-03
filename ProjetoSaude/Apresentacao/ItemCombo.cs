namespace ProjetoSaude.Apresentacao
{
    public class ItemCombo
    {
        public ItemCombo(string text, object value)
        {
            Text = text;
            Value = value;
        }

        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}