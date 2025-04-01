using Model.Enums;
using MongoDB.Bson;

public class User
{


    // Constructor to initialize a User object
    public User(ObjectId id, string firstName, string lastName, string username, string password, string email, Roles role)
    {
        this.Id = id;
        this.First_Name = firstName;
        this.Last_Name = lastName;
        this.Username = username;
        this.Password = password;
        this.Email = email;
        this.Role = role;
    }
    public ObjectId Id { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public Roles Role { get; set; }
    public string Reset_Token { get; set; } 
    public DateTime? Token_Expiration { get; set; } 

        
    
        public User(BsonDocument document)
        {
            this.Id = (ObjectId)document["_id"];
            this.First_Name = (string)document["first_name"];
            this.Last_Name = (string)document["last_name"];
            this.Username = (string)document["username"];
            this.Password = (string)document["password"];
            this.Email = (string)document["email"];
            if (document["role"].IsString)
            {
                this.Role = (Roles)Enum.Parse(typeof(Roles), document["role"].AsString);
            }
            else if (document["role"].IsInt32)
            {
                this.Role = (Roles)document["role"].AsInt32;
            }
            if (document.Contains("reset_token"))
            {
                this.Reset_Token = document["reset_token"].ToString();
            }
            if (document.Contains("token_expiration"))
            {
                this.Token_Expiration = document["token_expiration"].ToNullableUniversalTime();
            }
        }
        public override string ToString()
        {
            return this.Username;
        }
        public User() { }

    // Constructor to handle BSONDocument from MongoDB
/*    public User(BsonDocument document)
    {
        this.Id = (ObjectId)document["_id"];
        this.First_Name = document.Contains("first_name") ? document["first_name"].AsString : "Unknown";
        this.Last_Name = document.Contains("last_name") ? document["last_name"].AsString : "Unknown";
        this.Username = document.Contains("username") ? document["username"].AsString : "Unknown";
        this.Password = document.Contains("password") ? document["password"].AsString : string.Empty;
        this.Email = document.Contains("email") ? document["email"].AsString : string.Empty;
        this.Role = document.Contains("role") ? (Roles)(int)document["role"] : Roles.employee;
    }*/

}
