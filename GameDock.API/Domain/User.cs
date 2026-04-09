namespace GameDock.Api.Domain;
public class User
{
    public bool IsAdmin { get; set; }
    public int UserId {get; set;}
    public string UserName { get; set; }
    public string Email { get; set; }
    public string PasswordHash {get; set;}
    public DateTime CreatedAt { get; set; }
    
    
    public User(bool isAdmin, int userId, string userName, string  email, string passwordHash, DateTime  createdAt)
        {
        this.isAdmin = IsAdmin;
        this.userId = UserId;
        this.userName = UserName;
        this.email = Email;
        this.passwordHash = PasswordHash;
        this.createdAt = CreatedAt;
        }
}