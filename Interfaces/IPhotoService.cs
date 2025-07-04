﻿using CloudinaryDotNet.Actions;

namespace WebApplication7.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file); 
        Task<DeletionResult>DeletePhotoAsync(string publicId);
    }
}
