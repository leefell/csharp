namespace Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        // Um cliente é igual o outro se o email é igual

        public override bool Equals(object? obj)
        {
            if(!(obj is Client))
            {
                return false;
            }

            Client other = obj as Client; // downcast

            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
