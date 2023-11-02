using AutoMapper;
using Training.FileExplorer.Api.Models.Dtos;
using Training.FileExplorer.Application.FileStorage.Models.Storage;

namespace N60.FileExplorer.Api.Common.MapperProfiles;

public class DirectoryProfile : Profile
{
    public DirectoryProfile()
    {
        CreateMap<StorageDirectory, StorageDirectoryDto>();
        CreateMap<StorageDirectoryDto, StorageDirectory>();
    }
}