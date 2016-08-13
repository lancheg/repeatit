using Core.Domain;
using RepeatIt.Domain.Entities;
using RepeatIt.Domain.Models;
using System.Globalization;
namespace RepeatIt.Domain.Services
{
    public class CardGenerator
    {
        private readonly IRepository<Phrase> _phraseRepository;

        public CardGenerator(IRepository<Phrase> phraseRepository)
        {
            _phraseRepository = phraseRepository;
        }

        public Card Generate(CultureInfo sourceCulture, CultureInfo destinationCulture)
        {
            var sourcePhrase = _phraseRepository.Get(9);
            var destinationPhrase = sourcePhrase.GetLocalized(destinationCulture);

            var card = new Card(sourcePhrase, destinationPhrase);

            return card;
        }
    }
}
