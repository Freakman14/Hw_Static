using Domain.Models;

namespace Infrucstruction;

public static class CategoryServices
{
    public static List<Category> listcategory = new List<Category>() { };

    public static void CreateCategory(Category category)
    {
        listcategory.Add(category);
    }
    public static List<Category> GetCategories()
    {
        return listcategory;
    }
    public static Category GetCategoryById(Category category)
    {
        var categid = listcategory.FirstOrDefault(e => e.Id == category.Id);
        return categid;
    }
    public static Category GetCategoryByName(Category category)
    {
        var categname = listcategory.FirstOrDefault(e => e.Name == category.Name);
        return categname;
    }
    public static List<Category> GetCategoryByDate(DateTime date)
    {
        listcategory.FirstOrDefault(e => e.CreatedAt == date);
        return listcategory;
    }
    public static void DeletePost(int id)
    {
        var simple = listcategory.FirstOrDefault(e => e.Id == id);
        listcategory.Remove(simple);
        System.Console.WriteLine(listcategory);
    }
}
