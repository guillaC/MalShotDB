![mdb](https://user-images.githubusercontent.com/6315083/192282485-b77f3080-0b6b-4624-b85e-1c619cc2441a.png)
# Remote Storm V1.2 - Remote Storm.exe
## Informations
| Label | Value |
| :--- | ---: |
| Executable Name | Remote Storm.exe |
| Product Name | Remote Storm V1.2 |
| Version Number | 1.02 |
| Description |  |
| Company Name | Casa |
| Copyright |  |
| Trademarks |  |
| Last Edition | 10/03/2000 00:12:48 |
| Size | 105472 |
| SHA1 🔎 | [D2B73E9CBD5427E9CB2ABC72B4BBFA0CEC7F5751](https://www.virustotal.com/gui/search/D2B73E9CBD5427E9CB2ABC72B4BBFA0CEC7F5751) |
| Language | English (United States) |
## Static Analysis
<details>
<summary>Manalyze</summary>
<p>

```

* Manalyze 0.9 *

-------------------------------------------------------------------------------
C:/Users/IEUser/Desktop/net6.0/Malwares/Remote Storm 1.2/Remote Storm 1.2/Remote Storm.exe
-------------------------------------------------------------------------------

Summary:
--------
Architecture:       IMAGE_FILE_MACHINE_I386
Subsystem:          IMAGE_SUBSYSTEM_WINDOWS_GUI
Compilation Date:   2000-Mar-09 21:12:46
Detected languages: English - United States
Comments:           Remote Storm V1.2 by Impactus
CompanyName:        Casa
ProductName:        Remote Storm V1.2
FileVersion:        1.02
ProductVersion:     1.02
InternalName:       Remote Storm
OriginalFilename:   Remote Storm.exe

DOS Header:
-----------
e_magic:    MZ
e_cblp:     0x0090
e_cp:       0x0003
e_crlc:     0x0000
e_cparhdr:  0x0004
e_minalloc: 0x0000
e_maxalloc: 0xFFFF
e_ss:       0x0000
e_sp:       0x00B8
e_csum:     0x0000
e_ip:       0x0000
e_cs:       0x0000
e_ovno:     0x0000
e_oemid:    0x0000
e_oeminfo:  0x0000
e_lfanew:   0x00000080

PE Header:
----------
Signature:            PE
Machine:              IMAGE_FILE_MACHINE_I386
NumberofSections:     3
TimeDateStamp:        2000-Mar-09 21:12:46
PointerToSymbolTable: 0x00000000
NumberOfSymbols:      0
SizeOfOptionalHeader: 0x00E0
Characteristics:      IMAGE_FILE_32BIT_MACHINE
                      IMAGE_FILE_EXECUTABLE_IMAGE
                      IMAGE_FILE_LINE_NUMS_STRIPPED
                      IMAGE_FILE_LOCAL_SYMS_STRIPPED
                      IMAGE_FILE_RELOCS_STRIPPED

Image Optional Header:
----------------------
Magic:                   PE32
LinkerVersion:           4.2
SizeOfCode:              0x0001A000
SizeOfInitializedData:   0x00001000
SizeOfUninitializedData: 0x0003E000
AddressOfEntryPoint:     0x00058020 (Section: UPX1)
BaseOfCode:              0x0003F000
BaseOfData:              0x00059000
ImageBase:               0x00400000
SectionAlignment:        0x00001000
FileAlignment:           0x00000200
OperatingSystemVersion:  4.0
ImageVersion:            1.2
SubsystemVersion:        4.0
Win32VersionValue:       0
SizeOfImage:             0x0005A000
SizeOfHeaders:           0x00000200
Checksum:                0x00000000
Subsystem:               IMAGE_SUBSYSTEM_WINDOWS_GUI
SizeofStackReserve:      0x00100000
SizeofStackCommit:       0x00001000
SizeofHeapReserve:       0x00100000
SizeofHeapCommit:        0x00001000
LoaderFlags:             0x00000000
NumberOfRvaAndSizes:     16

Sections:
---------
UPX0:
    VirtualSize:          0x0003E000
    VirtualAddress:       0x00001000
    SizeOfRawData:        0x00000000
    PointerToRawData:     0x00000200
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_UNINITIALIZED_DATA
                          IMAGE_SCN_MEM_EXECUTE
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE

UPX1:
    VirtualSize:          0x0001A000
    VirtualAddress:       0x0003F000
    SizeOfRawData:        0x00019200
    PointerToRawData:     0x00000200
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_EXECUTE
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              7.9042

.rsrc:
    VirtualSize:          0x00001000
    VirtualAddress:       0x00059000
    SizeOfRawData:        0x00000800
    PointerToRawData:     0x00019400
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              2.86817


Imports:
--------
KERNEL32.DLL: LoadLibraryA
              GetProcAddress
              ExitProcess
MSVBVM50.DLL: #619

Resources:
----------
30001:
    Type:          RT_ICON
    Language:      UNKNOWN
    Codepage:      Unicode (UTF 16LE)
    Size:          744
    TimeDateStamp: 2000-Mar-09 21:12:44
    Entropy:       1.70755

1:
    Type:              RT_GROUP_ICON
    Language:          UNKNOWN
    Codepage:          Unicode (UTF 16LE)
    Size:              20
    TimeDateStamp:     2000-Mar-09 21:12:44
    Entropy:           2.55772
    Detected Filetype: Icon file

1 (#2):
    Type:          RT_VERSION
    Language:      English - United States
    Codepage:      Unicode (UTF 16LE)
    Size:          644
    TimeDateStamp: 2000-Mar-09 21:12:44
    Entropy:       3.23159


Version Info:
-------------
Resource LangID: English - United States
VS_VERSION_INFO:
    Signature:           0xFEEF04BD
    StructVersion:       0x00010000
    FileVersion:         1.2.0.0
    ProductVersion:      1.2.0.0
    FileFlags:           (EMPTY)
    FileOs:              VOS_DOS_WINDOWS32
                         VOS_NT_WINDOWS32
                         VOS__WINDOWS32
    FileType:            VFT_APP
    Language:            English - United States
    Comments:            Remote Storm V1.2 by Impactus
    CompanyName:         Casa
    ProductName:         Remote Storm V1.2
    FileVersion (#2):    1.02
    ProductVersion (#2): 1.02
    InternalName:        Remote Storm
    OriginalFilename:    Remote Storm.exe


[ SUSPICIOUS ] PEiD Signature:
    UPX -> www.upx.sourceforge.net

Interesting strings found in the binary:
    Contains domain names:
        http://upx.tsx.org
        upx.tsx.org

[ SUSPICIOUS ] The PE is packed with UPX
    Unusual section name found: UPX0
    Section UPX0 is both writable and executable.
    Unusual section name found: UPX1
    Section UPX1 is both writable and executable.
    The PE only has 4 import(s).

The PE contains common functions which appear in legitimate applications.
    [!] The program may be hiding some of its imports:
        LoadLibraryA
        GetProcAddress

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
### Remote Storm 1.2 - Not Connected
![UI](./Screenshots/Remote%20Storm_Remote%20Storm%201.2%20-%20Not%20Connected_df49f12062ea48de937e52165b8f2be9.png) 
