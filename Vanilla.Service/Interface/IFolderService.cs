using System;
using System.Collections.Generic;
using Vanilla.Service.ViewModel;
using Vanilla.Service.Messaging;
using Vanilla.Service.Messaging.FolderService;

namespace Vanilla.Service.Interface
{
    public interface IFolderService
    {
        GetFolderResponse GetFolderBy(GetFolderRequest r);

        GetFoldersResponse GetAllFolders();
        GetFoldersResponse GetChildFolders(GetFoldersRequest r);

        CreateFolderResponse AddFolder(CreateFolderRequest r);
        SaveFolderResponse SaveFolder(SaveFolderRequest r);
        RemoveFolderResponse RemoveFolder(RemoveFolderRequest r);
    }
}
