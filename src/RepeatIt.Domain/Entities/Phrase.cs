using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Core.Domain;

namespace RepeatIt.Domain.Entities
{
    public class Phrase:IEntity
    {
        public CultureInfo Culture { get; set; }

        public string Text { get; set; }

        public string Example { get; set; }

        public virtual ICollection<Phrase> Translations { get; set; }

        public Phrase GetLocalized(CultureInfo culture)
        {
            return Translations.FirstOrDefault(x => x.Culture.Equals(culture));
        }

        public int Id { get; set; }
    }
}
