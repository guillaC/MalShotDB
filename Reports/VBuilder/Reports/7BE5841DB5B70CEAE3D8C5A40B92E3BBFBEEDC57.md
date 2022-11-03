![mdb](https://user-images.githubusercontent.com/6315083/192282485-b77f3080-0b6b-4624-b85e-1c619cc2441a.png)
# HICHKAS - HICHKAS.exe
## Informations
| Label | Value |
| :--- | ---: |
| Executable Name | HICHKAS.exe |
| Product Name | HICHKAS |
| Version Number | 1.00 |
| Description | Programmer : Mehran Rasa |
| Company Name | Virus Maker Software . |
| Copyright |  |
| Trademarks |  |
| Last Edition | 13/03/2014 07:07:04 |
| Size | 294912 |
| SHA1 🔎 | [7BE5841DB5B70CEAE3D8C5A40B92E3BBFBEEDC57](https://www.virustotal.com/gui/search/7BE5841DB5B70CEAE3D8C5A40B92E3BBFBEEDC57) |
| Language | English (United States) |
## Static Analysis
<details>
<summary>Manalyze</summary>
<p>

```

* Manalyze 0.9 *

-------------------------------------------------------------------------------
C:/Users/IEUser/Desktop/net6.0/Malwares/HICHKAS.exe
-------------------------------------------------------------------------------

Summary:
--------
Architecture:       IMAGE_FILE_MACHINE_I386
Subsystem:          IMAGE_SUBSYSTEM_WINDOWS_GUI
Compilation Date:   2007-Jun-04 19:33:47
Detected languages: English - United States
                    Farsi - Iran
CompanyName:        Virus Maker Software .
FileDescription:    Programmer : Mehran Rasa
ProductName:        HICHKAS
FileVersion:        1.00
ProductVersion:     1.00
InternalName:       HICHKAS
OriginalFilename:   HICHKAS.exe

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
e_lfanew:   0x000000C8

PE Header:
----------
Signature:            PE
Machine:              IMAGE_FILE_MACHINE_I386
NumberofSections:     3
TimeDateStamp:        2007-Jun-04 19:33:47
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
LinkerVersion:           6.0
SizeOfCode:              0x00047000
SizeOfInitializedData:   0x00001000
SizeOfUninitializedData: 0x00091000
AddressOfEntryPoint:     0x000D8C20 (Section: UPX1)
BaseOfCode:              0x00092000
BaseOfData:              0x000D9000
ImageBase:               0x00400000
SectionAlignment:        0x00001000
FileAlignment:           0x00000200
OperatingSystemVersion:  4.0
ImageVersion:            1.0
SubsystemVersion:        4.0
Win32VersionValue:       0
SizeOfImage:             0x000DA000
SizeOfHeaders:           0x00001000
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
    VirtualSize:          0x00091000
    VirtualAddress:       0x00001000
    SizeOfRawData:        0x00000000
    PointerToRawData:     0x00000400
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_UNINITIALIZED_DATA
                          IMAGE_SCN_MEM_EXECUTE
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE

UPX1:
    VirtualSize:          0x00047000
    VirtualAddress:       0x00092000
    SizeOfRawData:        0x00046E00
    PointerToRawData:     0x00000400
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_EXECUTE
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              7.86731

.rsrc:
    VirtualSize:          0x00001000
    VirtualAddress:       0x000D9000
    SizeOfRawData:        0x00000E00
    PointerToRawData:     0x00047200
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              4.76114


Imports:
--------
KERNEL32.DLL: LoadLibraryA
              GetProcAddress
              ExitProcess
MSVBVM60.DLL: #616

Resources:
----------
101:
    Type:          CUSTOM
    Language:      Farsi - Iran
    Codepage:      Unicode (UTF 16LE)
    Size:          28160
    TimeDateStamp: 2007-Jun-04 19:33:47
    Entropy:       7.89535

102:
    Type:          CUSTOM
    Language:      Farsi - Iran
    Codepage:      Unicode (UTF 16LE)
    Size:          20604
    TimeDateStamp: 2007-Jun-04 19:33:47
    Entropy:       7.70894

103:
    Type:          CUSTOM
    Language:      Farsi - Iran
    Codepage:      Unicode (UTF 16LE)
    Size:          152848
    TimeDateStamp: 2007-Jun-04 19:33:47
    Entropy:       7.84997

30001:
    Type:          RT_ICON
    Language:      UNKNOWN
    Codepage:      Unicode (UTF 16LE)
    Size:          2216
    TimeDateStamp: 2007-Jun-04 19:33:47
    Entropy:       4.78694

1:
    Type:              RT_GROUP_ICON
    Language:          UNKNOWN
    Codepage:          Unicode (UTF 16LE)
    Size:              20
    TimeDateStamp:     2007-Jun-04 19:33:47
    Entropy:           2.22322
    Detected Filetype: Icon file

1 (#2):
    Type:          RT_VERSION
    Language:      English - United States
    Codepage:      Unicode (UTF 16LE)
    Size:          644
    TimeDateStamp: 2007-Jun-04 19:33:47
    Entropy:       3.26959


Version Info:
-------------
Resource LangID: English - United States
VS_VERSION_INFO:
    Signature:           0xFEEF04BD
    StructVersion:       0x00010000
    FileVersion:         1.0.0.0
    ProductVersion:      1.0.0.0
    FileFlags:           (EMPTY)
    FileOs:              VOS_DOS_WINDOWS32
                         VOS_NT_WINDOWS32
                         VOS__WINDOWS32
    FileType:            VFT_APP
    Language:            English - United States
    CompanyName:         Virus Maker Software .
    FileDescription:     Programmer : Mehran Rasa
    ProductName:         HICHKAS
    FileVersion (#2):    1.00
    ProductVersion (#2): 1.00
    InternalName:        HICHKAS
    OriginalFilename:    HICHKAS.exe


RICH Header:
------------
XOR Key:          0x88CEA841
Unmarked objects: 0
14 (7299):        1
9 (8041):         3
13 (8169):        1

[ SUSPICIOUS ] PEiD Signature:
    UPX -> www.upx.sourceforge.net

[ SUSPICIOUS ] Strings found in the binary may indicate undesirable behavior:
    Miscellaneous malware strings:
        Virus
    Contains domain names:
        ans.aD.com

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

The PE's resources present abnormal characteristics.
    Resource 101 is possibly compressed or encrypted.
    Resource 102 is possibly compressed or encrypted.
    Resource 103 is possibly compressed or encrypted.

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
###  HIC-HKAS Virus Maker
![UI](./Screenshots/HICHKAS_%20HIC-HKAS%20Virus%20Maker_c618970147274598bfaa461c619f0e39.png) 
