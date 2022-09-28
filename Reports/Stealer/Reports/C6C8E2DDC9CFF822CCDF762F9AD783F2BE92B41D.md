![mdb](https://user-images.githubusercontent.com/6315083/192282485-b77f3080-0b6b-4624-b85e-1c619cc2441a.png)
#  - Multi Password Stealer_1.6.exe
## Informations
| Label | Value |
| :--- | ---: |
| Executable Name | Multi Password Stealer_1.6.exe |
| Product Name |  |
| Version Number |  |
| Description |  |
| Company Name |  |
| Copyright |  |
| Trademarks |  |
| Last Edition | 01/01/2008 22:20:00 |
| Size | 1964032 |
| SHA1 🔎 | [C6C8E2DDC9CFF822CCDF762F9AD783F2BE92B41D](https://www.virustotal.com/gui/search/C6C8E2DDC9CFF822CCDF762F9AD783F2BE92B41D) |
| MD5 | D41D8CD98F00B204E9800998ECF8427E |
| Language |  |
## Static Analysis
<details>
<summary>Manalyze</summary>
<p>

```

* Manalyze 0.9 *

-------------------------------------------------------------------------------
C:/Users/aTest/Desktop/net6.0/Malwares/Multi Password Stealer_1.6/Multi Password Stealer_1.6.exe
-------------------------------------------------------------------------------

Summary:
--------
Architecture:       IMAGE_FILE_MACHINE_I386
Subsystem:          IMAGE_SUBSYSTEM_WINDOWS_GUI
Compilation Date:   1992-Jun-19 22:22:17
Detected languages: English - United States
                    German - Germany

DOS Header:
-----------
e_magic:    MZ
e_cblp:     0x0050
e_cp:       0x0002
e_crlc:     0x0000
e_cparhdr:  0x0004
e_minalloc: 0x000F
e_maxalloc: 0xFFFF
e_ss:       0x0000
e_sp:       0x00B8
e_csum:     0x0000
e_ip:       0x0000
e_cs:       0x0000
e_ovno:     0x001A
e_oemid:    0x0000
e_oeminfo:  0x0000
e_lfanew:   0x00000100

PE Header:
----------
Signature:            PE
Machine:              IMAGE_FILE_MACHINE_I386
NumberofSections:     8
TimeDateStamp:        1992-Jun-19 22:22:17
PointerToSymbolTable: 0x00000000
NumberOfSymbols:      0
SizeOfOptionalHeader: 0x00E0
Characteristics:      IMAGE_FILE_32BIT_MACHINE
                      IMAGE_FILE_BYTES_REVERSED_HI
                      IMAGE_FILE_BYTES_REVERSED_LO
                      IMAGE_FILE_EXECUTABLE_IMAGE
                      IMAGE_FILE_LINE_NUMS_STRIPPED
                      IMAGE_FILE_LOCAL_SYMS_STRIPPED

Image Optional Header:
----------------------
Magic:                   PE32
LinkerVersion:           2.0
SizeOfCode:              0x000B2400
SizeOfInitializedData:   0x0012D000
SizeOfUninitializedData: 0x00000000
AddressOfEntryPoint:     0x000B3174 (Section: CODE)
BaseOfCode:              0x00001000
BaseOfData:              0x000B4000
ImageBase:               0x00400000
SectionAlignment:        0x00001000
FileAlignment:           0x00000200
OperatingSystemVersion:  4.0
ImageVersion:            0.0
SubsystemVersion:        4.0
Win32VersionValue:       0
SizeOfImage:             0x001E7000
SizeOfHeaders:           0x00000400
Checksum:                0x00000000
Subsystem:               IMAGE_SUBSYSTEM_WINDOWS_GUI
SizeofStackReserve:      0x00100000
SizeofStackCommit:       0x00004000
SizeofHeapReserve:       0x00100000
SizeofHeapCommit:        0x00001000
LoaderFlags:             0x00000000
NumberOfRvaAndSizes:     16

Sections:
---------
CODE:
    VirtualSize:          0x000B2234
    VirtualAddress:       0x00001000
    SizeOfRawData:        0x000B2400
    PointerToRawData:     0x00000400
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_CODE
                          IMAGE_SCN_MEM_EXECUTE
                          IMAGE_SCN_MEM_READ
    Entropy:              6.54737

DATA:
    VirtualSize:          0x00002C68
    VirtualAddress:       0x000B4000
    SizeOfRawData:        0x00002E00
    PointerToRawData:     0x000B2800
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              5.00418

BSS:
    VirtualSize:          0x000011BD
    VirtualAddress:       0x000B7000
    SizeOfRawData:        0x00000000
    PointerToRawData:     0x000B5600
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE

.idata:
    VirtualSize:          0x000026F8
    VirtualAddress:       0x000B9000
    SizeOfRawData:        0x00002800
    PointerToRawData:     0x000B5600
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              4.98534

.tls:
    VirtualSize:          0x00000010
    VirtualAddress:       0x000BC000
    SizeOfRawData:        0x00000000
    PointerToRawData:     0x000B7E00
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE

.rdata:
    VirtualSize:          0x00000018
    VirtualAddress:       0x000BD000
    SizeOfRawData:        0x00000200
    PointerToRawData:     0x000B7E00
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_SHARED
    Entropy:              0.200582

.reloc:
    VirtualSize:          0x0000C0B8
    VirtualAddress:       0x000BE000
    SizeOfRawData:        0x0000C200
    PointerToRawData:     0x000B8000
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_SHARED
    Entropy:              6.63641

.rsrc:
    VirtualSize:          0x0011B600
    VirtualAddress:       0x000CB000
    SizeOfRawData:        0x0011B600
    PointerToRawData:     0x000C4200
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_SHARED
    Entropy:              7.21767


Imports:
--------
kernel32.dll:      DeleteCriticalSection
                   LeaveCriticalSection
                   EnterCriticalSection
                   InitializeCriticalSection
                   VirtualFree
                   VirtualAlloc
                   LocalFree
                   LocalAlloc
                   GetTickCount
                   QueryPerformanceCounter
                   GetVersion
                   GetCurrentThreadId
                   InterlockedDecrement
                   InterlockedIncrement
                   VirtualQuery
                   WideCharToMultiByte
                   MultiByteToWideChar
                   lstrlenA
                   lstrcpynA
                   LoadLibraryExA
                   GetThreadLocale
                   GetStartupInfoA
                   GetProcAddress
                   GetModuleHandleA
                   GetModuleFileNameA
                   GetLocaleInfoA
                   GetCommandLineA
                   FreeLibrary
                   FindFirstFileA
                   FindClose
                   ExitProcess
                   ExitThread
                   CreateThread
                   WriteFile
                   UnhandledExceptionFilter
                   RtlUnwind
                   RaiseException
                   GetStdHandle
user32.dll:        GetKeyboardType
                   LoadStringA
                   MessageBoxA
                   CharNextA
advapi32.dll:      RegQueryValueExA
                   RegOpenKeyExA
                   RegCloseKey
oleaut32.dll:      SysFreeString
                   SysReAllocStringLen
                   SysAllocStringLen
kernel32.dll (#2): DeleteCriticalSection
                   LeaveCriticalSection
                   EnterCriticalSection
                   InitializeCriticalSection
                   VirtualFree
                   VirtualAlloc
                   LocalFree
                   LocalAlloc
                   GetTickCount
                   QueryPerformanceCounter
                   GetVersion
                   GetCurrentThreadId
                   InterlockedDecrement
                   InterlockedIncrement
                   VirtualQuery
                   WideCharToMultiByte
                   MultiByteToWideChar
                   lstrlenA
                   lstrcpynA
                   LoadLibraryExA
                   GetThreadLocale
                   GetStartupInfoA
                   GetProcAddress
                   GetModuleHandleA
                   GetModuleFileNameA
                   GetLocaleInfoA
                   GetCommandLineA
                   FreeLibrary
                   FindFirstFileA
                   FindClose
                   ExitProcess
                   ExitThread
                   CreateThread
                   WriteFile
                   UnhandledExceptionFilter
                   RtlUnwind
                   RaiseException
                   GetStdHandle
advapi32.dll (#2): RegQueryValueExA
                   RegOpenKeyExA
                   RegCloseKey
kernel32.dll (#3): DeleteCriticalSection
                   LeaveCriticalSection
                   EnterCriticalSection
                   InitializeCriticalSection
                   VirtualFree
                   VirtualAlloc
                   LocalFree
                   LocalAlloc
                   GetTickCount
                   QueryPerformanceCounter
                   GetVersion
                   GetCurrentThreadId
                   InterlockedDecrement
                   InterlockedIncrement
                   VirtualQuery
                   WideCharToMultiByte
                   MultiByteToWideChar
                   lstrlenA
                   lstrcpynA
                   LoadLibraryExA
                   GetThreadLocale
                   GetStartupInfoA
                   GetProcAddress
                   GetModuleHandleA
                   GetModuleFileNameA
                   GetLocaleInfoA
                   GetCommandLineA
                   FreeLibrary
                   FindFirstFileA
                   FindClose
                   ExitProcess
                   ExitThread
                   CreateThread
                   WriteFile
                   UnhandledExceptionFilter
                   RtlUnwind
                   RaiseException
                   GetStdHandle
version.dll:       VerQueryValueA
                   GetFileVersionInfoSizeA
                   GetFileVersionInfoA
gdi32.dll:         UnrealizeObject
                   StretchBlt
                   SetWindowOrgEx
                   SetWinMetaFileBits
                   SetViewportOrgEx
                   SetTextColor
                   SetStretchBltMode
                   SetROP2
                   SetPixel
                   SetMapMode
                   SetEnhMetaFileBits
                   SetDIBColorTable
                   SetBrushOrgEx
                   SetBkMode
                   SetBkColor
                   SelectPalette
                   SelectObject
                   SelectClipRgn
                   SaveDC
                   RoundRect
                   RestoreDC
                   Rectangle
                   RectVisible
                   RealizePalette
                   Polyline
                   PlayEnhMetaFile
                   PatBlt
                   MoveToEx
                   MaskBlt
                   LineTo
                   LPtoDP
                   IntersectClipRect
                   GetWindowOrgEx
                   GetWinMetaFileBits
                   GetTextMetricsA
                   GetTextExtentPointA
                   GetTextExtentPoint32A
                   GetSystemPaletteEntries
                   GetStockObject
                   GetPixel
                   GetPaletteEntries
                   GetObjectA
                   GetEnhMetaFilePaletteEntries
                   GetEnhMetaFileHeader
                   GetEnhMetaFileDescriptionA
                   GetEnhMetaFileBits
                   GetDeviceCaps
                   GetDIBits
                   GetDIBColorTable
                   GetDCOrgEx
                   GetCurrentPositionEx
                   GetCurrentObject
                   GetClipBox
                   GetBrushOrgEx
                   GetBitmapBits
                   GdiFlush
                   ExtCreateRegion
                   ExcludeClipRect
                   Ellipse
                   DeleteObject
                   DeleteEnhMetaFile
                   DeleteDC
                   CreateSolidBrush
                   CreateRectRgn
                   CreatePenIndirect
                   CreatePalette
                   CreateHalftonePalette
                   CreateFontIndirectA
                   CreateEnhMetaFileA
                   CreateDIBitmap
                   CreateDIBSection
                   CreateCompatibleDC
                   CreateCompatibleBitmap
                   CreateBrushIndirect
                   CreateBitmap
                   CopyEnhMetaFileA
                   CombineRgn
                   CloseEnhMetaFile
                   BitBlt
user32.dll (#2):   GetKeyboardType
                   LoadStringA
                   MessageBoxA
                   CharNextA
kernel32.dll (#4): DeleteCriticalSection
                   LeaveCriticalSection
                   EnterCriticalSection
                   InitializeCriticalSection
                   VirtualFree
                   VirtualAlloc
                   LocalFree
                   LocalAlloc
                   GetTickCount
                   QueryPerformanceCounter
                   GetVersion
                   GetCurrentThreadId
                   InterlockedDecrement
                   InterlockedIncrement
                   VirtualQuery
                   WideCharToMultiByte
                   MultiByteToWideChar
                   lstrlenA
                   lstrcpynA
                   LoadLibraryExA
                   GetThreadLocale
                   GetStartupInfoA
                   GetProcAddress
                   GetModuleHandleA
                   GetModuleFileNameA
                   GetLocaleInfoA
                   GetCommandLineA
                   FreeLibrary
                   FindFirstFileA
                   FindClose
                   ExitProcess
                   ExitThread
                   CreateThread
                   WriteFile
                   UnhandledExceptionFilter
                   RtlUnwind
                   RaiseException
                   GetStdHandle
oleaut32.dll (#2): SysFreeString
                   SysReAllocStringLen
                   SysAllocStringLen
ole32.dll:         CreateStreamOnHGlobal
                   IsAccelerator
                   OleDraw
                   OleSetMenuDescriptor
                   CoTaskMemFree
                   ProgIDFromCLSID
                   StringFromCLSID
                   CoCreateInstance
                   CoGetClassObject
                   CoUninitialize
                   CoInitialize
                   IsEqualGUID
oleaut32.dll (#3): SysFreeString
                   SysReAllocStringLen
                   SysAllocStringLen
comctl32.dll:      ImageList_SetIconSize
                   ImageList_GetIconSize
                   ImageList_Write
                   ImageList_Read
                   ImageList_GetDragImage
                   ImageList_DragShowNolock
                   ImageList_SetDragCursorImage
                   ImageList_DragMove
                   ImageList_DragLeave
                   ImageList_DragEnter
                   ImageList_EndDrag
                   ImageList_BeginDrag
                   ImageList_LoadImageA
                   ImageList_Remove
                   ImageList_DrawEx
                   ImageList_Replace
                   ImageList_Draw
                   ImageList_GetBkColor
                   ImageList_SetBkColor
                   ImageList_ReplaceIcon
                   ImageList_Add
                   ImageList_GetImageCount
                   ImageList_Destroy
                   ImageList_Create
                   InitCommonControls
shell32.dll:       ShellExecuteA

Resources:
----------
1:
    Type:          RT_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.6633

2:
    Type:          RT_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.80231

3:
    Type:          RT_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.00046

4:
    Type:          RT_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.56318

5:
    Type:          RT_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.6949

6:
    Type:          RT_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.62527

7:
    Type:          RT_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.91604

BBABORT:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.92079

BBALL:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          484
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.16995

BBCANCEL:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.92079

BBCLOSE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.68492

BBHELP:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.88085

BBIGNORE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.29718

BBNO:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.58804

BBOK:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.67459

BBRETRY:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.53344

BBYES:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.67459

CDROM:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          192
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.78825

CLOSEDFOLDER:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          224
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.01477

CURRENTFOLDER:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          224
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.97986

EXECUTABLE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          224
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.96393

FLOPPY:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          192
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.63812

HARD:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          192
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.62043

KNOWNFILE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          224
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.83217

NETWORK:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          192
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.73457

OPENFOLDER:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          224
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.0519

PREVIEWGLYPH:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          232
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.85172

RAM:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          192
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.73213

SBLEFT:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          208
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.0184

SBLEFTDIS:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          208
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.79554

SBLEFTDN:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          208
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.40721

SBRIGHT:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          208
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.00455

SBRIGHTDIS:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          208
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.86813

SBRIGHTDN:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          208
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.00311

UNKNOWNFILE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          224
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.50975

VCLSKINMENU:
    Type:          RT_BITMAP
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          176
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.0994

1 (#2):
    Type:          RT_ICON
    Language:      German - Germany
    Codepage:      UNKNOWN
    Size:          1640
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.99866

2 (#2):
    Type:          RT_ICON
    Language:      German - Germany
    Codepage:      UNKNOWN
    Size:          744
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       4.27398

3 (#2):
    Type:          RT_ICON
    Language:      German - Germany
    Codepage:      UNKNOWN
    Size:          296
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.63972

4 (#2):
    Type:          RT_ICON
    Language:      German - Germany
    Codepage:      UNKNOWN
    Size:          3752
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       5.65814

5 (#2):
    Type:          RT_ICON
    Language:      German - Germany
    Codepage:      UNKNOWN
    Size:          2216
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       6.24584

6 (#2):
    Type:          RT_ICON
    Language:      German - Germany
    Codepage:      UNKNOWN
    Size:          1384
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.89324

7 (#2):
    Type:          RT_ICON
    Language:      German - Germany
    Codepage:      UNKNOWN
    Size:          9640
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       5.35465

8:
    Type:          RT_ICON
    Language:      German - Germany
    Codepage:      UNKNOWN
    Size:          4264
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       5.85347

9:
    Type:          RT_ICON
    Language:      German - Germany
    Codepage:      UNKNOWN
    Size:          1128
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       5.47986

DLGTEMPLATE:
    Type:          RT_DIALOG
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          82
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.5627

4073:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          576
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.27291

4074:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1476
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.28617

4075:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1404
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.25043

4076:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1084
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.28809

4077:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          884
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.3655

4078:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1312
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.30121

4079:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1552
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.35527

4080:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          584
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.24876

4081:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          500
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.18497

4082:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          256
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.09778

4083:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1232
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.25371

4084:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          256
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.12999

4085:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          312
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.16084

4086:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          784
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.25329

4087:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1632
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.21628

4088:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          988
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.3524

4089:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1236
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.25882

4090:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1408
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.30255

4091:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          232
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.87227

4092:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          204
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       2.90688

4093:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          808
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.33418

4094:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1240
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.33914

4095:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          828
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.39165

4096:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1020
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       3.23245

DVCLAL:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          16
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       4

INSTALL:
    Type:              RT_RCDATA
    Language:          German - Germany
    Codepage:          UNKNOWN
    Size:              729600
    TimeDateStamp:     2007-Aug-31 16:49:04
    Entropy:           6.79648
    Detected Filetype: PE Executable

PACKAGEINFO:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1580
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       5.34094

TFORM1:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          54623
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       7.91687

TFORM2:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1070
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       5.49724

TFORM3:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          35180
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       7.05908

TFORM4:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          2070
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       5.59233

TFRMREGISTER:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          11388
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       4.83536

TFRMUPX:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          642
    TimeDateStamp: 2007-Aug-31 16:49:04
    Entropy:       5.48018

UPX:
    Type:              RT_RCDATA
    Language:          German - Germany
    Codepage:          UNKNOWN
    Size:              261120
    TimeDateStamp:     2007-Aug-31 16:49:04
    Entropy:           7.99251
    Detected Filetype: PE Executable

32761:
    Type:              RT_GROUP_CURSOR
    Language:          UNKNOWN
    Codepage:          UNKNOWN
    Size:              20
    TimeDateStamp:     2007-Aug-31 16:49:04
    Entropy:           1.83876
    Detected Filetype: Cursor file

32762:
    Type:              RT_GROUP_CURSOR
    Language:          UNKNOWN
    Codepage:          UNKNOWN
    Size:              20
    TimeDateStamp:     2007-Aug-31 16:49:04
    Entropy:           1.91924
    Detected Filetype: Cursor file

32763:
    Type:              RT_GROUP_CURSOR
    Language:          UNKNOWN
    Codepage:          UNKNOWN
    Size:              20
    TimeDateStamp:     2007-Aug-31 16:49:04
    Entropy:           2.01924
    Detected Filetype: Cursor file

32764:
    Type:              RT_GROUP_CURSOR
    Language:          UNKNOWN
    Codepage:          UNKNOWN
    Size:              20
    TimeDateStamp:     2007-Aug-31 16:49:04
    Entropy:           2.01924
    Detected Filetype: Cursor file

32765:
    Type:              RT_GROUP_CURSOR
    Language:          UNKNOWN
    Codepage:          UNKNOWN
    Size:              20
    TimeDateStamp:     2007-Aug-31 16:49:04
    Entropy:           2.01924
    Detected Filetype: Cursor file

32766:
    Type:              RT_GROUP_CURSOR
    Language:          UNKNOWN
    Codepage:          UNKNOWN
    Size:              20
    TimeDateStamp:     2007-Aug-31 16:49:04
    Entropy:           2.01924
    Detected Filetype: Cursor file

32767:
    Type:              RT_GROUP_CURSOR
    Language:          UNKNOWN
    Codepage:          UNKNOWN
    Size:              20
    TimeDateStamp:     2007-Aug-31 16:49:04
    Entropy:           2.01924
    Detected Filetype: Cursor file

MAINICON:
    Type:              RT_GROUP_ICON
    Language:          German - Germany
    Codepage:          UNKNOWN
    Size:              132
    TimeDateStamp:     2007-Aug-31 16:49:04
    Entropy:           2.89097
    Detected Filetype: Icon file


TLS Callbacks:
--------------
StartAddressOfRawData: 0x004BC000
EndAddressOfRawData:   0x004BC010
AddressOfIndex:        0x004B40A0
AddressOfCallbacks:    0x004BD010
SizeOfZeroFill:        0x00000000
Characteristics:       IMAGE_SCN_TYPE_REG
Callbacks:             (EMPTY)

[ SUSPICIOUS ] PEiD Signature:
    UPX V2.00-V2.90 -> Markus Oberhumer &amp; Laszlo Molnar &amp; John Reiser
    UPX v2.0 -> Markus, Laszlo & Reiser (h)
    UPX 2.00-3.0X -> Markus Oberhumer &amp; Laszlo Molnar &amp; John Reiser
    UPX -> www.upx.sourceforge.net
    UPX V2.00-V2.90 -> Markus Oberhumer & Laszlo Molnar & John Reiser
    UPX 2.00-3.0X -> Markus Oberhumer & Laszlo Molnar & John Reiser

[ SUSPICIOUS ] Strings found in the binary may indicate undesirable behavior:
    Looks for VMWare presence:
        ba 58 56 00 00 ed 81 fb 68 58 4d 56 
    Contains another PE executable:
        This program cannot be run in DOS mode.
    Contains domain names:
        Messenger.com
        Stealer.com
        hotmail.com
        http://uploaded.to
        http://upx.sf.net
        mail.gmx.net
        upx.sf.net

Cryptographic algorithms detected in the binary:
    Uses constants related to MD5

[ MALICIOUS ] The PE contains functions mostly used by malware.
    [!] The program may be hiding some of its imports:
        LoadLibraryExA
        GetProcAddress
        LoadLibraryA
    Functions which can be used for anti-debugging purposes:
        FindWindowA
    Code injection capabilities (PowerLoader):
        GetWindowLongA
        FindWindowA
    Can access the registry:
        RegQueryValueExA
        RegOpenKeyExA
        RegCloseKey
    Possibly launches other programs:
        ShellExecuteA
    Can create temporary files:
        GetTempPathA
        CreateFileA
    Uses functions commonly found in keyloggers:
        MapVirtualKeyA
        GetForegroundWindow
        CallNextHookEx
    Can take screenshots:
        CreateCompatibleDC
        BitBlt
        GetDCEx
        GetDC
        FindWindowA
    Reads the contents of the clipboard:
        GetClipboardData

[ MALICIOUS ] The PE header may have been manually modified.
    Resource INSTALL detected as a PE Executable.
    Resource TFORM1 is possibly compressed or encrypted.
    Resource TFORM3 is possibly compressed or encrypted.
    Resource UPX detected as a PE Executable.
    The resource timestamps differ from the PE header:
        2007-Aug-31 16:49:04

The following exploit mitigation techniques have been detected
    Stack Canary: disabled
    SafeSEH: disabled
    ASLR: disabled
    DEP: disabled
    CFG: disabled




```

</p>
</details>

## Screenshots
### Erreur de script
![UI](./Screenshots/M.M.H%20v1.6_Erreur%20de%20script_02a8ba8356c541d692344ec1dced8646.png) 
### M.M.H v1.6
![UI](./Screenshots/M.M.H%20v1.6_M.M.H%20v1.6_4c7636bc01794c46a4ec3122c5b584f7.png) 
