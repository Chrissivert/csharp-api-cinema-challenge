using Microsoft.AspNetCore.Mvc;

public static class ScreeningEndpoints
{
    public static void MapScreeningEndpoints(this WebApplication app)
    {
        app.MapGet("/screenings", async ([FromServices] IScreeningRepository repo) =>
        {
            var screening = await repo.GetAllAsync();
            return Results.Ok(screening);
        })
        .WithTags("Screenings");

        app.MapPost("/screenings", async (Screening screening, [FromServices] IScreeningRepository repo) =>
        {
            var createdMovie = await repo.CreateAsync(screening);
            return Results.Created($"/screenings/{createdMovie.Id}", createdMovie);
        })
        .WithTags("Screenings");
    }
}
