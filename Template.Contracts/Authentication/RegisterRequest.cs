
namespace Template.Contracts.Authentication;
    public record RegisterRequest
    (
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Password

    );

