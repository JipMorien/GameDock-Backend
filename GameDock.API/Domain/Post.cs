namespace GameDock.Api.Domain;
public class Post
{
    public int PostId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public int UserId { get; set; }

    public Post(int postId, string content, DateTime createdAt, int userId)
    {
        this.postId = PostId;
        this.content = Content;
        this.createdAt = CreatedAt;
        this.userId = UserId;
    }
}