using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Memo.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
