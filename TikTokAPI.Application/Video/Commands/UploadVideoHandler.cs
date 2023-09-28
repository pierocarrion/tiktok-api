using Ardalis.Result;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokAPI.Application.Video.Commands;

public class UploadVideoHandler : IRequestHandler<UploadVideoCommand, Result<UploadVideoResponse>>
{
    public Task<Result<UploadVideoResponse>> Handle(UploadVideoCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
