using api_cinema_challenge.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public static class RegisterEndpoints
{
    public static void MapRegisterEndpoints(this WebApplication app)
    {
        app.MapPost("/register", async (User user, CinemaContext db) =>
        {
            //password in plaintext :(
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return Results.Ok(user);
        });

    }
}