using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Memo.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
