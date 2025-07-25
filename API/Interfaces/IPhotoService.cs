using System;
using CloudinaryDotNet.Actions;

namespace API.Interfaces;

public interface IPhotoService
{
    Task<ImageUploadResult> AddPotoAsync(IFormFile file);
    Task<DeletionResult> DeletePhotoAsync(string publicId);
}
