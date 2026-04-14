using System.Drawing;

namespace MemoryGame
{
    public enum EtatCarte
    {
        Cachee,
        Revelee,
        Trouvee
    }

    public class Carte
    {
        public int Id { get; set; }
        public Image Face { get; set; }
        public EtatCarte Etat { get; set; }

        public Carte(int id, Image face)
        {
            Id = id;
            Face = face;
            Etat = EtatCarte.Cachee;
        }
    }
}
