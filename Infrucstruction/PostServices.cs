using System.Data.Common;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using Domain.Models;

namespace Infrucstruction;

public static class PostServices
{

    public static List<Post> listpost = new List<Post>() { };

    public static void CreatePost(Post post)
    {
        listpost.Add(post);
    }
    public static List<Post> GetPosts()
    {
        return listpost;
    }

    public static Post GetPostById(Post post)
    {
        var postid = listpost.FirstOrDefault(e => e.Id == post.Id);
        return postid;
    }

    public static Post GetPostByName(Post post)
    {
        var postname = listpost.FirstOrDefault(e => e.Title == post.Title);
        return postname;
    }
    public static List<Post> GetPostsByDate(DateTime date)
    {
        listpost.FirstOrDefault(e => e.CreatedAt == date);
        return listpost;
    }

    public static List<Post> GetPostsByCategoryId(int id)
    {
        listpost.FirstOrDefault(e => e.Id == id);
        return listpost;
    }

    public static void DeletePost(int id)
    {
        var cip = listpost.FirstOrDefault(e => e.Id == id);
        listpost.Remove(cip);
        System.Console.WriteLine(listpost);
    }

}
