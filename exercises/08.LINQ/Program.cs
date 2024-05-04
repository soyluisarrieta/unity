var names = new List<string>() { "Luis", "Jessica", "Paola", "Dalia", "Isabela", "Sebastian" };
var namesResult1 = from name in names
                   where name.Length > 6
                   orderby name descending
                   select name;

// Solo imprimirá los que tengan más de 6 caracteres
foreach (var name in namesResult1)
{
    Console.WriteLine(name);
    /* Sebastian
     * Jessica
     * Isabela 
     */
}




string[] otherNames = { "Luis", "Jessica", "Paola", "Dalia", "Isabela", "Sebastian" };
var namesResult2 = from name in otherNames
                   where name.Length < 6
                   orderby name ascending
                   select name;

// Solo imprimirá los que tengan menos de 6 caracteres
foreach (var name in namesResult2)
{
    Console.WriteLine(name);
    /* Dalia
     * Luis
     * Paola 
     */
}




string[] andOtherNames = { "Luis", "Jessica", "Paola", "Dalia", "Isabela", "Sebastian" };
var namesResult3 = andOtherNames.Where(name => name == "Dalia" || name == "Sebastian")
                                .OrderByDescending(name => name.Length)
                                .Select(d=>d);

// Solo imprimirá los que tengan sea igual a Dalia o Sebastian
foreach (var name in namesResult3)
{
    Console.WriteLine(name);
    /* Dalia
     * Sebastian
     */
}