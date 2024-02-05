using APIServer;

internal class TeacherCollection
{
    List<Teacher> teachers = [
        new() {Name = "Micke", HitPoints = 100},
        new() {Name = "Martin", HitPoints = 3},
        new() {Name = "Lena", HitPoints = 9000}
    ];

    public IResult GetTeacher(int number)
    {
        if (number < 0 || number >= teachers.Count)
        {
            return Results.NotFound();
        }

        return Results.Ok(teachers[number]);
    }
}
