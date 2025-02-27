using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppStarPare.Behavior
{
    public class PlacaBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnTextChanged;
            base.OnDetachingFrom(entry);
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Entry)sender;
            var text = e.NewTextValue?.ToUpper() ?? string.Empty;

            // Aplica a máscara AAA-0000
            if (text.Length >= 3 && !text.Contains('-'))
            {
                text = text.Insert(3, "-");
            }

            // Valida caracteres permitidos
            text = Regex.Replace(text, @"[^A-Z0-9-]", string.Empty);

            // Limita tamanho
            if (text.Length > 8) text = text[..8];

            entry.Text = text;
        }
    }
}
