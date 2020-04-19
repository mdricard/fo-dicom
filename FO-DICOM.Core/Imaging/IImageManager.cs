﻿// Copyright (c) 2012-2020 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

namespace FellowOakDicom.Imaging
{
    public interface IImageManager
    {

        IImage CreateImage(int width, int height);

    }
}
