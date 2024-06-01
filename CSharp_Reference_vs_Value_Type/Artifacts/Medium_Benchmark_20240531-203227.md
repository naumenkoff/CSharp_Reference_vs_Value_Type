| Method                                        |     Mean |     Error |    StdDev |   Gen0 | Allocated |
|-----------------------------------------------|---------:|----------:|----------:|-------:|----------:|
| Process_Struct_POCO_Default                   | 1.052 ns | 0.0061 ns | 0.0091 ns |      - |         - |
| Process_Struct_POCO_Ref                       | 1.058 ns | 0.0033 ns | 0.0048 ns |      - |         - |
| Process_Struct_POCO_In                        | 1.054 ns | 0.0070 ns | 0.0104 ns |      - |         - |
| Process_Struct_POCO_RefReadonly               | 1.061 ns | 0.0044 ns | 0.0066 ns |      - |         - |
| Process_Struct_NPOCO_Default                  | 2.778 ns | 0.0072 ns | 0.0107 ns |      - |         - |
| Process_Struct_NPOCO_Ref                      | 3.218 ns | 0.0257 ns | 0.0377 ns |      - |         - |
| Process_Struct_NPOCO_In                       | 3.215 ns | 0.0393 ns | 0.0563 ns |      - |         - |
| Process_Struct_NPOCO_RefReadonly              | 3.226 ns | 0.0213 ns | 0.0312 ns |      - |         - |
| Process_Readonly_Struct_POCO_Default          | 1.050 ns | 0.0058 ns | 0.0086 ns |      - |         - |
| Process_Readonly_Struct_POCO_Ref              | 1.055 ns | 0.0037 ns | 0.0055 ns |      - |         - |
| Process_Readonly_Struct_POCO_In               | 1.057 ns | 0.0067 ns | 0.0098 ns |      - |         - |
| Process_Readonly_Struct_POCO_RefReadonly      | 1.059 ns | 0.0057 ns | 0.0085 ns |      - |         - |
| Process_Readonly_Struct_NPOCO_Default         | 2.776 ns | 0.0104 ns | 0.0155 ns |      - |         - |
| Process_Readonly_Struct_NPOCO_Ref             | 3.240 ns | 0.0205 ns | 0.0307 ns |      - |         - |
| Process_Readonly_Struct_NPOCO_In              | 3.245 ns | 0.0259 ns | 0.0387 ns |      - |         - |
| Process_Readonly_Struct_NPOCO_RefReadonly     | 3.210 ns | 0.0236 ns | 0.0353 ns |      - |         - |
| Process_Ref_Struct_POCO_Default               | 1.054 ns | 0.0050 ns | 0.0074 ns |      - |         - |
| Process_Ref_Struct_POCO_Ref                   | 1.057 ns | 0.0075 ns | 0.0112 ns |      - |         - |
| Process_Ref_Struct_POCO_In                    | 1.055 ns | 0.0039 ns | 0.0058 ns |      - |         - |
| Process_Ref_Struct_POCO_RefReadonly           | 1.059 ns | 0.0052 ns | 0.0078 ns |      - |         - |
| Process_Ref_Struct_NPOCO_Default              | 2.777 ns | 0.0071 ns | 0.0106 ns |      - |         - |
| Process_Ref_Struct_NPOCO_Ref                  | 3.220 ns | 0.0145 ns | 0.0212 ns |      - |         - |
| Process_Ref_Struct_NPOCO_In                   | 3.211 ns | 0.0124 ns | 0.0178 ns |      - |         - |
| Process_Ref_Struct_NPOCO_RefReadonly          | 3.228 ns | 0.0188 ns | 0.0282 ns |      - |         - |
| Process_Readonly_Ref_Struct_POCO_Default      | 1.051 ns | 0.0030 ns | 0.0043 ns |      - |         - |
| Process_Readonly_Ref_Struct_POCO_Ref          | 1.048 ns | 0.0066 ns | 0.0099 ns |      - |         - |
| Process_Readonly_Ref_Struct_POCO_In           | 1.053 ns | 0.0052 ns | 0.0078 ns |      - |         - |
| Process_Readonly_Ref_Struct_POCO_RefReadonly  | 1.051 ns | 0.0040 ns | 0.0059 ns |      - |         - |
| Process_Readonly_Ref_Struct_NPOCO_Default     | 2.765 ns | 0.0075 ns | 0.0112 ns |      - |         - |
| Process_Readonly_Ref_Struct_NPOCO_Ref         | 3.172 ns | 0.0261 ns | 0.0383 ns |      - |         - |
| Process_Readonly_Ref_Struct_NPOCO_In          | 3.194 ns | 0.0209 ns | 0.0313 ns |      - |         - |
| Process_Readonly_Ref_Struct_NPOCO_RefReadonly | 3.203 ns | 0.0261 ns | 0.0391 ns |      - |         - |
| Process_Class_POCO_Default                    | 2.527 ns | 0.0062 ns | 0.0093 ns | 0.0025 |      40 B |
| Process_Class_POCO_Ref                        | 2.744 ns | 0.0118 ns | 0.0173 ns | 0.0025 |      40 B |
| Process_Class_POCO_In                         | 2.758 ns | 0.0175 ns | 0.0257 ns | 0.0025 |      40 B |
| Process_Class_POCO_RefReadonly                | 2.738 ns | 0.0092 ns | 0.0132 ns | 0.0025 |      40 B |
| Process_Class_NPOCO_Default                   | 4.222 ns | 0.0132 ns | 0.0198 ns | 0.0025 |      40 B |
| Process_Class_NPOCO_Ref                       | 4.647 ns | 0.0159 ns | 0.0238 ns | 0.0025 |      40 B |
| Process_Class_NPOCO_In                        | 4.651 ns | 0.0085 ns | 0.0121 ns | 0.0025 |      40 B |
| Process_Class_NPOCO_RefReadonly               | 4.650 ns | 0.0126 ns | 0.0185 ns | 0.0025 |      40 B |
| Process_IReadonly_Struct_NPOCO_Default        | 8.941 ns | 0.0188 ns | 0.0281 ns | 0.0025 |      40 B |
| Process_IReadonly_Struct_NPOCO_Ref            | 8.983 ns | 0.0258 ns | 0.0379 ns | 0.0025 |      40 B |
| Process_IReadonly_Struct_NPOCO_In             | 8.943 ns | 0.0261 ns | 0.0383 ns | 0.0025 |      40 B |
| Process_IReadonly_Struct_NPOCO_RefReadonly    | 8.945 ns | 0.0237 ns | 0.0354 ns | 0.0025 |      40 B |