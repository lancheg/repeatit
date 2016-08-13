using RepeatIt.Domain.Entities;

namespace RepeatIt.Domain.Models
{
    public class Card
    {
        private Phrase _destinationPhrase;
        private Phrase _sourcePhrase;

        public Card(Phrase sourcePhrase, Phrase destinationPhrase)
        {
            _sourcePhrase = sourcePhrase;
            _destinationPhrase = destinationPhrase;
        }

        public string Text
        {
            get { return _sourcePhrase.Text; }
        }

        public string Example
        {
            get { return _sourcePhrase.Example; }
        }


        public string TextTranslation
        {
            get { return _destinationPhrase.Text; }
        }


        public string ExampleTranslation
        {
            get { return _destinationPhrase.Example; }
        }
    }
}
