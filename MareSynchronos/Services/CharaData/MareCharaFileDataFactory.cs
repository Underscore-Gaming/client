using UnsungSync.API.Data;
using UnsungSync.FileCache;
using UnsungSync.Services.CharaData.Models;

namespace UnsungSync.Services.CharaData;

public sealed class MareCharaFileDataFactory
{
    private readonly FileCacheManager _fileCacheManager;

    public MareCharaFileDataFactory(FileCacheManager fileCacheManager)
    {
        _fileCacheManager = fileCacheManager;
    }

    public MareCharaFileData Create(string description, CharacterData characterCacheDto)
    {
        return new MareCharaFileData(_fileCacheManager, description, characterCacheDto);
    }
}