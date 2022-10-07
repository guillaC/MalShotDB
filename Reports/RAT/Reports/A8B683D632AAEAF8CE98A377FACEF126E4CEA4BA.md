![mdb](https://user-images.githubusercontent.com/6315083/192282485-b77f3080-0b6b-4624-b85e-1c619cc2441a.png)
#  - Beast2.06.exe
## Informations
| Label | Value |
| :--- | ---: |
| Executable Name | Beast2.06.exe |
| Product Name |  |
| Version Number |  |
| Description |  |
| Company Name |  |
| Copyright |  |
| Trademarks |  |
| Last Edition | 18/02/2004 16:58:42 |
| Size | 823296 |
| SHA1 🔎 | [A8B683D632AAEAF8CE98A377FACEF126E4CEA4BA](https://www.virustotal.com/gui/search/A8B683D632AAEAF8CE98A377FACEF126E4CEA4BA) |
| Language |  |
## Static Analysis
<details>
<summary>Manalyze</summary>
<p>

```

* Manalyze 0.9 *

-------------------------------------------------------------------------------
C:/Users/IEUser/Desktop/net6.0/Malwares/Beast2.06/Beast2.06.exe
-------------------------------------------------------------------------------

Summary:
--------
Architecture:       IMAGE_FILE_MACHINE_I386
Subsystem:          IMAGE_SUBSYSTEM_WINDOWS_GUI
Compilation Date:   1992-Jun-19 22:22:17
Detected languages: English - United States
                    Russian - Russia

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
NumberofSections:     10
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
SizeOfCode:              0x0012CA00
SizeOfInitializedData:   0x000F0000
SizeOfUninitializedData: 0x00000000
AddressOfEntryPoint:     0x00224001 (Section: .aspack)
BaseOfCode:              0x00001000
BaseOfData:              0x0012E000
ImageBase:               0x00400000
SectionAlignment:        0x00001000
FileAlignment:           0x00000200
OperatingSystemVersion:  4.0
ImageVersion:            0.0
SubsystemVersion:        4.0
Win32VersionValue:       0
SizeOfImage:             0x00228000
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
    VirtualSize:          0x0012D000
    VirtualAddress:       0x00001000
    SizeOfRawData:        0x00068400
    PointerToRawData:     0x00000400
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              7.99951

DATA:
    VirtualSize:          0x00005000
    VirtualAddress:       0x0012E000
    SizeOfRawData:        0x00001A00
    PointerToRawData:     0x00068800
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              7.75923

BSS:
    VirtualSize:          0x00003000
    VirtualAddress:       0x00133000
    SizeOfRawData:        0x00000000
    PointerToRawData:     0x0006A200
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE

.idata:
    VirtualSize:          0x00003000
    VirtualAddress:       0x00136000
    SizeOfRawData:        0x00001200
    PointerToRawData:     0x0006A200
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              7.71776

.tls:
    VirtualSize:          0x00001000
    VirtualAddress:       0x00139000
    SizeOfRawData:        0x00000000
    PointerToRawData:     0x0006B400
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE

.rdata:
    VirtualSize:          0x00001000
    VirtualAddress:       0x0013A000
    SizeOfRawData:        0x00000200
    PointerToRawData:     0x0006B400
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              0.210826

.reloc:
    VirtualSize:          0x00014000
    VirtualAddress:       0x0013B000
    SizeOfRawData:        0x00000000
    PointerToRawData:     0x0006B600
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE

.rsrc:
    VirtualSize:          0x000D5000
    VirtualAddress:       0x0014F000
    SizeOfRawData:        0x0005B600
    PointerToRawData:     0x0006B600
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              7.97702

.aspack:
    VirtualSize:          0x00003000
    VirtualAddress:       0x00224000
    SizeOfRawData:        0x00002400
    PointerToRawData:     0x000C6C00
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              5.31262

.adata:
    VirtualSize:          0x00001000
    VirtualAddress:       0x00227000
    SizeOfRawData:        0x00000000
    PointerToRawData:     0x000C9000
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE


Imports:
--------
kernel32.dll:      GetProcAddress
                   GetModuleHandleA
                   LoadLibraryA
user32.dll:        GetKeyboardType
advapi32.dll:      RegQueryValueExA
oleaut32.dll:      SysFreeString
advapi32.dll (#2): RegQueryValueExA
version.dll:       VerQueryValueA
gdi32.dll:         UnrealizeObject
user32.dll (#2):   GetKeyboardType
oleaut32.dll (#2): SysFreeString
ole32.dll:         CoTaskMemAlloc
comctl32.dll:      ImageList_SetIconSize
imm32.dll:         ImmSetCompositionWindow
winspool.drv:      OpenPrinterA
shell32.dll:       Shell_NotifyIconA
wininet.dll:       InternetOpenUrlA
shell32.dll (#2):  Shell_NotifyIconA
comdlg32.dll:      GetSaveFileNameA
wsock32.dll:       WSACleanup
wininet.dll (#2):  InternetOpenUrlA
winmm.dll:         PlaySoundA

Resources:
----------
DL:
    Type:          DLL
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          31232
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.99439

ZIP:
    Type:          DLL
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          51200
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.99626

A:
    Type:          EXEFILE
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          32447
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.99441

B:
    Type:          EXEFILE
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          6832
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.97481

DIAL:
    Type:          EXEFILE
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          10416
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.98387

I:
    Type:          EXEFILE
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          9712
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.98011

P:
    Type:          EXEFILE
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          15360
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.98746

S:
    Type:          EXEFILE
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          66275
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.99631

U:
    Type:          EXEFILE
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          89600
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.99757

I0:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.73596

I1:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.72316

I10:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.73276

I11:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.72709

I12:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.74692

I13:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.62859

I14:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.63617

I15:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.69916

I16:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.70377

I17:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.76224

I18:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.72238

I2:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.69003

I3:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.72782

I4:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.72559

I5:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.66234

I6:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.71647

I7:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.69275

I8:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.73133

I9:
    Type:          IC
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          766
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.72684

L1:
    Type:          TXTFILE
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          607
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.58002

L2:
    Type:          TXTFILE
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          4523
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.95234

LOG:
    Type:          TXTFILE
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          2199
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.88229

W:
    Type:          WAVE
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          3064
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.93341

W1:
    Type:          WAVE
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          126
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       6.50498

1:
    Type:          RT_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.1911

2:
    Type:          RT_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.25052

3:
    Type:          RT_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.25371

4:
    Type:          RT_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.31399

5:
    Type:          RT_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.26722

6:
    Type:          RT_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.3242

7:
    Type:          RT_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.23742

BBABORT:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.49993

BBALL:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          484
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.52439

BBCANCEL:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.49338

BBCLOSE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.52112

BBHELP:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.59265

BBIGNORE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.54548

BBNO:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.52545

BBOK:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.5701

BBRETRY:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.52601

BBYES:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          464
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.42958

PREVIEWGLYPH:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          232
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.13958

TE_BTN_ABORT:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          360
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.39829

TE_BTN_ALL:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          360
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.29601

TE_BTN_CANCEL:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          360
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.33904

TE_BTN_CLOSE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          360
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.47766

TE_BTN_HELP:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          360
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.36424

TE_BTN_IGNORE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          360
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.3233

TE_BTN_NO:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          360
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.39866

TE_BTN_OK:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          360
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.38027

TE_BTN_RETRY:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          360
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.41424

TE_BTN_YES:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          360
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.32793

TE_FORM_CLOSE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          232
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.06031

TE_FORM_MAXIMIZE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          232
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.11697

TE_FORM_MINIMIZE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          308
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.25808

TE_FORM_MOVE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          232
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.01282

TE_FORM_RESTORE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          232
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.16051

TE_FORM_ROLLUP:
    Type:          RT_BITMAP
    Language:      Russian - Russia
    Codepage:      UNKNOWN
    Size:          232
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.13351

TE_FORM_SIZE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          232
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.04687

TE_FORM_TRAY:
    Type:          RT_BITMAP
    Language:      Russian - Russia
    Codepage:      UNKNOWN
    Size:          232
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.04573

TE_LIST_TRUETYPE:
    Type:          RT_BITMAP
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          200
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.03366

TE_SPIN_DOWN:
    Type:          RT_BITMAP
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          152
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       6.71987

TE_SPIN_UP:
    Type:          RT_BITMAP
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          152
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       6.7231

1 (#2):
    Type:          RT_ICON
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          2216
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       4.60809

2 (#2):
    Type:          RT_ICON
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          1384
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       3.65542

DLGTEMPLATE:
    Type:          RT_DIALOG
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          82
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       5.93371

4074:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          440
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.49921

4075:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          204
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       6.89883

4076:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          244
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.06775

4077:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          516
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.47883

4078:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          628
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.58146

4079:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          472
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.54832

4080:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          408
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.50162

4081:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          372
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.35668

4082:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          864
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.76724

4083:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          212
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.06842

4084:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          372
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.37306

4085:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          440
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.51926

4086:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1076
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.75258

4087:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          956
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.79276

4088:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          908
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.73041

4089:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          928
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.76919

4090:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1036
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       7.29721

4091:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          240
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       3.92308

4092:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          192
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       5.28075

4093:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          728
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       5.55927

4094:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1068
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       5.22479

4095:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          820
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       6.20476

4096:
    Type:          RT_STRING
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          756
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       6.08518

DVCLAL:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          16
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       3.57782

PACKAGEINFO:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1812
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       5.12833

TFORM1:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          46045
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       3.72526

TFORM10:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          2643
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM11:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          2050
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM12:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          97660
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM13:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          6741
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM14:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          4179
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM15:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          9379
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM16:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          9736
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM17:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          3842
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM18:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1011
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM19:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          20612
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM2:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          8030
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM20:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          3486
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM21:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          2799
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM22:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          2231
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM23:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          2648
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM24:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          6052
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM25:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          8003
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM26:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1961
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM27:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          2603
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM28:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          2827
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM29:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          2058
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM3:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          1895
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM31:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          5626
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM32:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          4115
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM33:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          4014
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM34:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          2046
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM35:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          4742
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM36:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          3710
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM37:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          6079
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM4:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          2378
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM5:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          44361
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM6:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          22231
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM7:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          6727
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM8:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          2579
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

TFORM9:
    Type:          RT_RCDATA
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          10881
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

XP_MAIN:
    Type:          RT_RCDATA
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          36490
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

XP_MAIN1:
    Type:          RT_RCDATA
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          29255
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

XP_METAL_MAIN:
    Type:          RT_RCDATA
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          27470
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

XP_METAL_MAIN1:
    Type:          RT_RCDATA
    Language:      English - United States
    Codepage:      UNKNOWN
    Size:          27837
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

32761:
    Type:          RT_GROUP_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          20
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

32762:
    Type:          RT_GROUP_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          20
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

32763:
    Type:          RT_GROUP_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          20
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

32764:
    Type:          RT_GROUP_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          20
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

32765:
    Type:          RT_GROUP_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          20
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

32766:
    Type:          RT_GROUP_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          20
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

32767:
    Type:          RT_GROUP_CURSOR
    Language:      UNKNOWN
    Codepage:      UNKNOWN
    Size:          20
    TimeDateStamp: 2004-Feb-18 17:58:40
    Entropy:       0

MAINICON:
    Type:              RT_GROUP_ICON
    Language:          English - United States
    Codepage:          UNKNOWN
    Size:              34
    TimeDateStamp:     2004-Feb-18 17:58:40
    Entropy:           2.32824
    Detected Filetype: Icon file


TLS Callbacks:
--------------
StartAddressOfRawData: 0x00539000
EndAddressOfRawData:   0x00539014
AddressOfIndex:        0x0052E0C4
AddressOfCallbacks:    0x0053A010
SizeOfZeroFill:        0x00000000
Characteristics:       IMAGE_SCN_TYPE_REG
Callbacks:             (EMPTY)

[ SUSPICIOUS ] PEiD Signature:
    ASPack v2.12

[ SUSPICIOUS ] The PE is packed with Aspack or Armadillo
    Unusual section name found: .aspack
    Unusual section name found: .adata
    The PE's resources are bigger than it is.

The PE contains common functions which appear in legitimate applications.
    [!] The program may be hiding some of its imports:
        GetProcAddress
        LoadLibraryA
    Can access the registry:
        RegQueryValueExA
        RegSetValueExA
    Has Internet access capabilities:
        InternetOpenUrlA
        InternetCheckConnectionA

[ SUSPICIOUS ] The PE header may have been manually modified.
    Resource DL is possibly compressed or encrypted.
    Resource ZIP is possibly compressed or encrypted.
    Resource A is possibly compressed or encrypted.
    Resource B is possibly compressed or encrypted.
    Resource DIAL is possibly compressed or encrypted.
    Resource I is possibly compressed or encrypted.
    Resource P is possibly compressed or encrypted.
    Resource S is possibly compressed or encrypted.
    Resource U is possibly compressed or encrypted.
    Resource I0 is possibly compressed or encrypted.
    Resource I1 is possibly compressed or encrypted.
    Resource I10 is possibly compressed or encrypted.
    Resource I11 is possibly compressed or encrypted.
    Resource I12 is possibly compressed or encrypted.
    Resource I13 is possibly compressed or encrypted.
    Resource I14 is possibly compressed or encrypted.
    Resource I15 is possibly compressed or encrypted.
    Resource I16 is possibly compressed or encrypted.
    Resource I17 is possibly compressed or encrypted.
    Resource I18 is possibly compressed or encrypted.
    Resource I2 is possibly compressed or encrypted.
    Resource I3 is possibly compressed or encrypted.
    Resource I4 is possibly compressed or encrypted.
    Resource I5 is possibly compressed or encrypted.
    Resource I6 is possibly compressed or encrypted.
    Resource I7 is possibly compressed or encrypted.
    Resource I8 is possibly compressed or encrypted.
    Resource I9 is possibly compressed or encrypted.
    Resource L1 is possibly compressed or encrypted.
    Resource L2 is possibly compressed or encrypted.
    Resource LOG is possibly compressed or encrypted.
    Resource W is possibly compressed or encrypted.
    Resource 1 is possibly compressed or encrypted.
    Resource 2 is possibly compressed or encrypted.
    Resource 3 is possibly compressed or encrypted.
    Resource 4 is possibly compressed or encrypted.
    Resource 5 is possibly compressed or encrypted.
    Resource 6 is possibly compressed or encrypted.
    Resource 7 is possibly compressed or encrypted.
    Resource BBABORT is possibly compressed or encrypted.
    Resource BBALL is possibly compressed or encrypted.
    Resource BBCANCEL is possibly compressed or encrypted.
    Resource BBCLOSE is possibly compressed or encrypted.
    Resource BBHELP is possibly compressed or encrypted.
    Resource BBIGNORE is possibly compressed or encrypted.
    Resource BBNO is possibly compressed or encrypted.
    Resource BBOK is possibly compressed or encrypted.
    Resource BBRETRY is possibly compressed or encrypted.
    Resource BBYES is possibly compressed or encrypted.
    Resource PREVIEWGLYPH is possibly compressed or encrypted.
    Resource TE_BTN_ABORT is possibly compressed or encrypted.
    Resource TE_BTN_ALL is possibly compressed or encrypted.
    Resource TE_BTN_CANCEL is possibly compressed or encrypted.
    Resource TE_BTN_CLOSE is possibly compressed or encrypted.
    Resource TE_BTN_HELP is possibly compressed or encrypted.
    Resource TE_BTN_IGNORE is possibly compressed or encrypted.
    Resource TE_BTN_NO is possibly compressed or encrypted.
    Resource TE_BTN_OK is possibly compressed or encrypted.
    Resource TE_BTN_RETRY is possibly compressed or encrypted.
    Resource TE_BTN_YES is possibly compressed or encrypted.
    Resource TE_FORM_CLOSE is possibly compressed or encrypted.
    Resource TE_FORM_MAXIMIZE is possibly compressed or encrypted.
    Resource TE_FORM_MINIMIZE is possibly compressed or encrypted.
    Resource TE_FORM_MOVE is possibly compressed or encrypted.
    Resource TE_FORM_RESTORE is possibly compressed or encrypted.
    Resource TE_FORM_ROLLUP is possibly compressed or encrypted.
    Resource TE_FORM_SIZE is possibly compressed or encrypted.
    Resource TE_FORM_TRAY is possibly compressed or encrypted.
    Resource TE_LIST_TRUETYPE is possibly compressed or encrypted.
    Resource 4074 is possibly compressed or encrypted.
    Resource 4076 is possibly compressed or encrypted.
    Resource 4077 is possibly compressed or encrypted.
    Resource 4078 is possibly compressed or encrypted.
    Resource 4079 is possibly compressed or encrypted.
    Resource 4080 is possibly compressed or encrypted.
    Resource 4081 is possibly compressed or encrypted.
    Resource 4082 is possibly compressed or encrypted.
    Resource 4083 is possibly compressed or encrypted.
    Resource 4084 is possibly compressed or encrypted.
    Resource 4085 is possibly compressed or encrypted.
    Resource 4086 is possibly compressed or encrypted.
    Resource 4087 is possibly compressed or encrypted.
    Resource 4088 is possibly compressed or encrypted.
    Resource 4089 is possibly compressed or encrypted.
    Resource 4090 is possibly compressed or encrypted.
    The resource timestamps differ from the PE header:
        2004-Feb-18 17:58:40
    Resources amount for 104.437% of the executable.

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
### Beast 2.06
![UI](./Screenshots/Beast2_Beast%202.06_c76328ce2e3748819a9087c9a68d16bf.png) 
