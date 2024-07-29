//dotnet class

//logical naming structure
namespace API.Entities;

//if i want to call this class just inside same namespace (API)
public class AppUser
{
//each of this proprties represent a column
//defult value of int =0 
//def value of refrence type (string)
public int Id { get; set; }
//? mean optional 
public required string UserName { get; set; }
 
}
