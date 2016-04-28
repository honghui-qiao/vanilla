using System;
using System.Collections.Generic;
using System.Linq;
using Vanilla.Model;
using Vanilla.Service.Interface;
using Vanilla.Service.Messaging;
using Vanilla.Service.Messaging.FolderService;
using Vanilla.Service.ViewModel;
using Vanilla.Service.Mapping;

namespace Vanilla.Service.Implementation
{
    public class FolderService : IFolderService
    {
        private IFolderRepository _rep;
        public FolderService(IFolderRepository rep)
        {
            _rep = rep;
        }

        public GetFolderResponse GetFolderBy(GetFolderRequest r)
        {
            GetFolderResponse response = new GetFolderResponse();
            try
            {
                response.Folder = _rep.FindBy(r.FolderId).ConvertToFolderView();
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public GetFoldersResponse GetAllFolders()
        {
            IEnumerable<Folder> folders = _rep.FindAll();
            GetFoldersResponse response = new GetFoldersResponse();

            response.Folders = _rep.FindAll().ConvertToFolderViews();
            response.Success = true;

            return response;
        }

        public GetFoldersResponse GetChildFolders(GetFoldersRequest r)
        {
            if (r.ParentFolderId == 0)
            {
                return GetAllFolders();
            }
            else
            {
                GetFoldersResponse response = new GetFoldersResponse();
                response.Folders = _rep.GetChildFolders(r.ParentFolderId).ConvertToFolderViews();
                response.Success = true;
                return response;
            }
        }

        public CreateFolderResponse AddFolder(CreateFolderRequest r)
        {
            Folder folder = new Folder();
            folder.FolderName = r.FolderName;
            folder.Description = r.Description;
            folder.AddedDate = DateTime.Now;
            folder.ModifiedDate = DateTime.Now;
            folder.ParentFolderId = r.ParentFolderId;

            CreateFolderResponse response = new CreateFolderResponse();
            try
            {
                response.FolderId = _rep.Add(folder);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public SaveFolderResponse SaveFolder(SaveFolderRequest r)
        {
            Folder folder = new Folder();
            folder.FolderName = r.Folder.FolderName;
            folder.Description = r.Folder.Description;
            folder.ModifiedDate = DateTime.Now;
            folder.ParentFolderId = r.Folder.ParentFolderId;

            SaveFolderResponse response = new SaveFolderResponse();
            try
            {
                _rep.Save(folder);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public RemoveFolderResponse RemoveFolder(RemoveFolderRequest r)
        {
            Folder folder = new Folder();
            folder.Id = r.FolderId;

            RemoveFolderResponse response = new RemoveFolderResponse();
            try
            {
                _rep.Remove(folder);
                response.Success = true;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
