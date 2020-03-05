using System;
using System.ComponentModel;

namespace NetPromoterScore.Util
{
    public enum DictionaryKey
    {
        NoDefinido = 0,
        Company = 1,
        Score = 2,
        User = 3,
        UserProfile = 4,
        UserType = 5
    }

    public enum UserProfiles : int
    {
        [Description("Votante")]
        Votante = 1,
        [Description("Administrador")]
        Administrador = 2
    }

    public enum UserTypes : int
    {
        [Description("Promotor")]
        Promotor = 1,
        [Description("Neutro")]
        Neutro = 2,
        [Description("Detractor")]
        Detractor = 3
    }

}
