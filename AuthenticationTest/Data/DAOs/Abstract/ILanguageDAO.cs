using System.Collections.Generic;
using AuthenticationTest.Data.Entities;

namespace AuthenticationTest.Data
{
    public interface ILanguageDAO
    {
        public List<Language> GetLanguages();
    }
}