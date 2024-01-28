namespace Entities
{
    internal class RegistroDeLog
    {
        public string Usuario { get; set; }
        public DateTime Instante { get; set; }

        public RegistroDeLog(string usuario, DateTime instante)
        {
            Usuario = usuario;
            Instante = instante;
        }

        public override int GetHashCode()
        {
            return Usuario.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is RegistroDeLog))
            {
                return false;
            }

            RegistroDeLog outro = obj as RegistroDeLog;

            return Usuario.Equals(outro.Usuario);
        }
    }
}
