namespace TodoApi.Dtos;

public record TodoItemDTO
(
    long Id,
    string? Name,
    bool IsComplete
);
