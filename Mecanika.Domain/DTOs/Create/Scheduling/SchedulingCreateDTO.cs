namespace Mecanika.Domain.DTOs.Create.Scheduling;
public record SchedulingCreateDTO
(
    TimeSpan InitialHour,
    TimeSpan FinalHour,
    string? Status,
    int ClientId,
    int ServiceId,
    int EmployeeId,
    int QueueId
);
