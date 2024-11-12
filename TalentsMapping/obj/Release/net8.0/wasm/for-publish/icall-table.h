#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
191,
200,
201,
202,
203,
204,
205,
206,
208,
209,
276,
277,
278,
307,
308,
309,
329,
330,
331,
332,
449,
450,
451,
454,
489,
490,
492,
494,
496,
498,
503,
511,
512,
513,
514,
515,
516,
517,
518,
519,
520,
614,
615,
680,
686,
689,
691,
696,
697,
699,
700,
704,
705,
707,
709,
710,
713,
714,
715,
718,
720,
723,
725,
727,
736,
801,
803,
805,
815,
816,
817,
819,
825,
826,
827,
828,
829,
837,
838,
839,
843,
844,
846,
848,
1045,
1221,
1222,
7014,
7015,
7017,
7018,
7019,
7020,
7021,
7023,
7025,
7027,
7037,
7039,
7046,
7048,
7050,
7052,
7103,
7104,
7106,
7107,
7108,
7109,
7110,
7112,
7114,
8121,
8125,
8127,
8128,
8129,
8130,
8379,
8380,
8381,
8382,
8400,
8401,
8402,
8404,
8445,
8504,
8506,
8508,
8517,
8518,
8519,
8520,
8915,
8920,
8921,
8948,
8966,
8973,
8980,
8991,
8994,
9014,
9087,
9089,
9098,
9100,
9101,
9108,
9122,
9142,
9143,
9151,
9153,
9160,
9161,
9164,
9166,
9171,
9177,
9178,
9185,
9187,
9199,
9202,
9203,
9204,
9215,
9224,
9230,
9231,
9232,
9234,
9235,
9252,
9254,
9268,
9285,
9312,
9342,
9343,
9827,
9919,
9920,
10120,
10121,
10128,
10129,
10130,
10135,
10210,
10594,
10595,
10817,
10827,
11491,
11512,
11514,
11516,
};
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal (int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy (int,int,int,int,int);
int ves_icall_System_Array_GetLengthInternal_raw (int,int,int);
int ves_icall_System_Array_GetLowerBoundInternal_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
void ves_icall_System_Array_GetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetValueRelaxedImpl_raw (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_ZeroMemory (int,int);
void ves_icall_System_Runtime_RuntimeImports_Memmove (int,int,int);
void ves_icall_System_Buffer_BulkMoveWithWriteBarrier (int,int,int,int);
int ves_icall_System_Delegate_AllocDelegateLike_internal_raw (int,int);
int ves_icall_System_Delegate_CreateDelegate_internal_raw (int,int,int,int,int);
int ves_icall_System_Delegate_GetVirtualMethod_internal_raw (int,int);
void ves_icall_System_Enum_GetEnumValuesAndNames_raw (int,int,int,int);
void ves_icall_System_Enum_InternalBoxEnum_raw (int,int,int64_t,int);
int ves_icall_System_Enum_InternalGetCorElementType (int);
void ves_icall_System_Enum_InternalGetUnderlyingType_raw (int,int,int);
int ves_icall_System_Environment_get_ProcessorCount ();
int ves_icall_System_Environment_get_TickCount ();
int64_t ves_icall_System_Environment_get_TickCount64 ();
void ves_icall_System_Environment_FailFast_raw (int,int,int,int);
void ves_icall_System_GC_register_ephemeron_array_raw (int,int);
int ves_icall_System_GC_get_ephemeron_tombstone_raw (int);
void ves_icall_System_GC_SuppressFinalize_raw (int,int);
void ves_icall_System_GC_ReRegisterForFinalize_raw (int,int);
void ves_icall_System_GC_GetGCMemoryInfo (int,int,int,int,int,int);
int ves_icall_System_GC_AllocPinnedArray_raw (int,int,int);
int ves_icall_System_Object_MemberwiseClone_raw (int,int);
double ves_icall_System_Math_Ceiling (double);
double ves_icall_System_Math_Cos (double);
double ves_icall_System_Math_Floor (double);
double ves_icall_System_Math_Log (double);
double ves_icall_System_Math_Log10 (double);
double ves_icall_System_Math_Pow (double,double);
double ves_icall_System_Math_Sin (double);
double ves_icall_System_Math_Sqrt (double);
double ves_icall_System_Math_Tan (double);
double ves_icall_System_Math_ModF (double,int);
void ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw (int,int,int);
void ves_icall_RuntimeMethodHandle_ReboxToNullable_raw (int,int,int,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
void ves_icall_RuntimeType_make_array_type_raw (int,int,int,int);
void ves_icall_RuntimeType_make_byref_type_raw (int,int,int);
void ves_icall_RuntimeType_make_pointer_type_raw (int,int,int);
void ves_icall_RuntimeType_MakeGenericType_raw (int,int,int,int);
int ves_icall_RuntimeType_GetMethodsByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetPropertiesByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetConstructors_native_raw (int,int,int);
int ves_icall_System_RuntimeType_CreateInstanceInternal_raw (int,int);
void ves_icall_System_RuntimeType_AllocateValueType_raw (int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringMethod_raw (int,int,int);
void ves_icall_System_RuntimeType_getFullName_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetGenericArgumentsInternal_raw (int,int,int,int);
int ves_icall_RuntimeType_GetGenericParameterPosition (int);
int ves_icall_RuntimeType_GetEvents_native_raw (int,int,int,int);
int ves_icall_RuntimeType_GetFields_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetInterfaces_raw (int,int,int);
int ves_icall_RuntimeType_GetNestedTypes_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringType_raw (int,int,int);
void ves_icall_RuntimeType_GetName_raw (int,int,int);
void ves_icall_RuntimeType_GetNamespace_raw (int,int,int);
int ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetAttributes (int);
int ves_icall_RuntimeTypeHandle_GetMetadataToken_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetCorElementType (int);
int ves_icall_RuntimeTypeHandle_HasInstantiation (int);
int ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_HasReferences_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetArrayRank_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetAssembly_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetElementType_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetModule_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetBaseType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition (int);
int ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw (int,int);
int ves_icall_RuntimeTypeHandle_is_subclass_of_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsByRefLike_raw (int,int);
void ves_icall_System_RuntimeTypeHandle_internal_from_name_raw (int,int,int,int,int,int);
int ves_icall_System_String_FastAllocateString_raw (int,int);
int ves_icall_System_Type_internal_from_handle_raw (int,int);
int ves_icall_System_ValueType_InternalGetHashCode_raw (int,int,int);
int ves_icall_System_ValueType_Equals_raw (int,int,int,int);
int ves_icall_System_Threading_Interlocked_CompareExchange_Int (int,int,int);
void ves_icall_System_Threading_Interlocked_CompareExchange_Object (int,int,int,int);
int ves_icall_System_Threading_Interlocked_Decrement_Int (int);
int ves_icall_System_Threading_Interlocked_Increment_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Increment_Long (int);
int ves_icall_System_Threading_Interlocked_Exchange_Int (int,int);
void ves_icall_System_Threading_Interlocked_Exchange_Object (int,int,int);
int64_t ves_icall_System_Threading_Interlocked_CompareExchange_Long (int,int64_t,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Exchange_Long (int,int64_t);
int ves_icall_System_Threading_Interlocked_Add_Int (int,int);
void ves_icall_System_Threading_Monitor_Monitor_Enter_raw (int,int);
void mono_monitor_exit_icall_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_wait_raw (int,int,int,int);
void ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw (int,int,int,int,int);
void ves_icall_System_Threading_Thread_InitInternal_raw (int,int);
int ves_icall_System_Threading_Thread_GetCurrentThread ();
void ves_icall_System_Threading_InternalThread_Thread_free_internal_raw (int,int);
int ves_icall_System_Threading_Thread_GetState_raw (int,int);
void ves_icall_System_Threading_Thread_SetState_raw (int,int,int);
void ves_icall_System_Threading_Thread_ClrState_raw (int,int,int);
void ves_icall_System_Threading_Thread_SetName_icall_raw (int,int,int,int);
int ves_icall_System_Threading_Thread_YieldInternal ();
void ves_icall_System_Threading_Thread_SetPriority_raw (int,int,int);
void ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw (int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw (int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw (int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw (int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw (int);
int ves_icall_System_GCHandle_InternalAlloc_raw (int,int,int);
void ves_icall_System_GCHandle_InternalFree_raw (int,int);
int ves_icall_System_GCHandle_InternalGet_raw (int,int);
void ves_icall_System_GCHandle_InternalSet_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError ();
void ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError (int);
void ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalTryGetHashCode_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw (int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw (int,int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack ();
int ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_InternalLoad_raw (int,int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetType_raw (int,int,int,int,int,int);
int ves_icall_System_Reflection_AssemblyName_GetNativeName (int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw (int,int);
int ves_icall_MonoCustomAttrs_IsDefinedInternal_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw (int,int);
int ves_icall_System_Reflection_LoaderAllocatorScout_Destroy (int);
void ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw (int,int,int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw (int,int,int,int,int);
void ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw (int,int,int,int,int,int,int);
void ves_icall_RuntimeEventInfo_get_event_info_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_ResolveType_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetParentType_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_GetFieldOffset_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetValueInternal_raw (int,int,int);
void ves_icall_RuntimeFieldInfo_SetValueInternal_raw (int,int,int,int);
int ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_get_method_info_raw (int,int,int);
int ves_icall_get_method_attributes (int);
int ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw (int,int,int);
int ves_icall_System_MonoMethodInfo_get_retval_marshal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw (int,int,int,int);
int ves_icall_RuntimeMethodInfo_get_name_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_base_method_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
void ves_icall_RuntimeMethodInfo_GetPInvoke_raw (int,int,int,int,int);
int ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw (int,int,int);
int ves_icall_RuntimeMethodInfo_GetGenericArguments_raw (int,int);
int ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw (int,int);
void ves_icall_InvokeClassConstructor_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw (int,int,int,int,int,int);
void ves_icall_RuntimePropertyInfo_get_property_info_raw (int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw (int,int,int);
void ves_icall_DynamicMethod_create_dynamic_method_raw (int,int,int,int,int);
void ves_icall_AssemblyBuilder_basic_init_raw (int,int);
void ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw (int,int);
void ves_icall_ModuleBuilder_basic_init_raw (int,int);
void ves_icall_ModuleBuilder_set_wrappers_type_raw (int,int,int);
int ves_icall_ModuleBuilder_getUSIndex_raw (int,int,int);
int ves_icall_ModuleBuilder_getToken_raw (int,int,int,int);
int ves_icall_ModuleBuilder_getMethodToken_raw (int,int,int,int);
void ves_icall_ModuleBuilder_RegisterToken_raw (int,int,int,int);
int ves_icall_TypeBuilder_create_runtime_class_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw (int,int);
int ves_icall_System_Diagnostics_StackFrame_GetFrameInfo (int,int,int,int,int,int,int,int);
void ves_icall_System_Diagnostics_StackTrace_GetTrace (int,int,int,int);
int ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass (int);
void ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree (int);
int ves_icall_Mono_SafeStringMarshal_StringToUtf8 (int);
void ves_icall_Mono_SafeStringMarshal_GFree (int);
static void *corlib_icall_funcs [] = {
// token 191,
ves_icall_System_Array_InternalCreate,
// token 200,
ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal,
// token 201,
ves_icall_System_Array_CanChangePrimitive,
// token 202,
ves_icall_System_Array_FastCopy,
// token 203,
ves_icall_System_Array_GetLengthInternal_raw,
// token 204,
ves_icall_System_Array_GetLowerBoundInternal_raw,
// token 205,
ves_icall_System_Array_GetGenericValue_icall,
// token 206,
ves_icall_System_Array_GetValueImpl_raw,
// token 208,
ves_icall_System_Array_SetValueImpl_raw,
// token 209,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 276,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 277,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 278,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 307,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 308,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 309,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 329,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 330,
ves_icall_System_Enum_InternalBoxEnum_raw,
// token 331,
ves_icall_System_Enum_InternalGetCorElementType,
// token 332,
ves_icall_System_Enum_InternalGetUnderlyingType_raw,
// token 449,
ves_icall_System_Environment_get_ProcessorCount,
// token 450,
ves_icall_System_Environment_get_TickCount,
// token 451,
ves_icall_System_Environment_get_TickCount64,
// token 454,
ves_icall_System_Environment_FailFast_raw,
// token 489,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 490,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 492,
ves_icall_System_GC_SuppressFinalize_raw,
// token 494,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 496,
ves_icall_System_GC_GetGCMemoryInfo,
// token 498,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 503,
ves_icall_System_Object_MemberwiseClone_raw,
// token 511,
ves_icall_System_Math_Ceiling,
// token 512,
ves_icall_System_Math_Cos,
// token 513,
ves_icall_System_Math_Floor,
// token 514,
ves_icall_System_Math_Log,
// token 515,
ves_icall_System_Math_Log10,
// token 516,
ves_icall_System_Math_Pow,
// token 517,
ves_icall_System_Math_Sin,
// token 518,
ves_icall_System_Math_Sqrt,
// token 519,
ves_icall_System_Math_Tan,
// token 520,
ves_icall_System_Math_ModF,
// token 614,
ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw,
// token 615,
ves_icall_RuntimeMethodHandle_ReboxToNullable_raw,
// token 680,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 686,
ves_icall_RuntimeType_make_array_type_raw,
// token 689,
ves_icall_RuntimeType_make_byref_type_raw,
// token 691,
ves_icall_RuntimeType_make_pointer_type_raw,
// token 696,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 697,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 699,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 700,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 704,
ves_icall_System_RuntimeType_CreateInstanceInternal_raw,
// token 705,
ves_icall_System_RuntimeType_AllocateValueType_raw,
// token 707,
ves_icall_RuntimeType_GetDeclaringMethod_raw,
// token 709,
ves_icall_System_RuntimeType_getFullName_raw,
// token 710,
ves_icall_RuntimeType_GetGenericArgumentsInternal_raw,
// token 713,
ves_icall_RuntimeType_GetGenericParameterPosition,
// token 714,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 715,
ves_icall_RuntimeType_GetFields_native_raw,
// token 718,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 720,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 723,
ves_icall_RuntimeType_GetDeclaringType_raw,
// token 725,
ves_icall_RuntimeType_GetName_raw,
// token 727,
ves_icall_RuntimeType_GetNamespace_raw,
// token 736,
ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw,
// token 801,
ves_icall_RuntimeTypeHandle_GetAttributes,
// token 803,
ves_icall_RuntimeTypeHandle_GetMetadataToken_raw,
// token 805,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 815,
ves_icall_RuntimeTypeHandle_GetCorElementType,
// token 816,
ves_icall_RuntimeTypeHandle_HasInstantiation,
// token 817,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 819,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 825,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 826,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 827,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 828,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 829,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 837,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 838,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition,
// token 839,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 843,
ves_icall_RuntimeTypeHandle_is_subclass_of_raw,
// token 844,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 846,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 848,
ves_icall_System_String_FastAllocateString_raw,
// token 1045,
ves_icall_System_Type_internal_from_handle_raw,
// token 1221,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1222,
ves_icall_System_ValueType_Equals_raw,
// token 7014,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 7015,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 7017,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 7018,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 7019,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 7020,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 7021,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 7023,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 7025,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 7027,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 7037,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 7039,
mono_monitor_exit_icall_raw,
// token 7046,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 7048,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 7050,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 7052,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 7103,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 7104,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 7106,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 7107,
ves_icall_System_Threading_Thread_GetState_raw,
// token 7108,
ves_icall_System_Threading_Thread_SetState_raw,
// token 7109,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 7110,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 7112,
ves_icall_System_Threading_Thread_YieldInternal,
// token 7114,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 8121,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 8125,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 8127,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 8128,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 8129,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 8130,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 8379,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 8380,
ves_icall_System_GCHandle_InternalFree_raw,
// token 8381,
ves_icall_System_GCHandle_InternalGet_raw,
// token 8382,
ves_icall_System_GCHandle_InternalSet_raw,
// token 8400,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 8401,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 8402,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 8404,
ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw,
// token 8445,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw,
// token 8504,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw,
// token 8506,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalTryGetHashCode_raw,
// token 8508,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 8517,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 8518,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 8519,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw,
// token 8520,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 8915,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 8920,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 8921,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 8948,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 8966,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 8973,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 8980,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 8991,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 8994,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 9014,
ves_icall_System_Reflection_LoaderAllocatorScout_Destroy,
// token 9087,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 9089,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 9098,
ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw,
// token 9100,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 9101,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 9108,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 9122,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 9142,
ves_icall_reflection_get_token_raw,
// token 9143,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 9151,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 9153,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 9160,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 9161,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 9164,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 9166,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 9171,
ves_icall_reflection_get_token_raw,
// token 9177,
ves_icall_get_method_info_raw,
// token 9178,
ves_icall_get_method_attributes,
// token 9185,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 9187,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 9199,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 9202,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 9203,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 9204,
ves_icall_reflection_get_token_raw,
// token 9215,
ves_icall_InternalInvoke_raw,
// token 9224,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 9230,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 9231,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 9232,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 9234,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 9235,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 9252,
ves_icall_InvokeClassConstructor_raw,
// token 9254,
ves_icall_InternalInvoke_raw,
// token 9268,
ves_icall_reflection_get_token_raw,
// token 9285,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 9312,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 9342,
ves_icall_reflection_get_token_raw,
// token 9343,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 9827,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 9919,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 9920,
ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw,
// token 10120,
ves_icall_ModuleBuilder_basic_init_raw,
// token 10121,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 10128,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 10129,
ves_icall_ModuleBuilder_getToken_raw,
// token 10130,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 10135,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 10210,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 10594,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 10595,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 10817,
ves_icall_System_Diagnostics_StackFrame_GetFrameInfo,
// token 10827,
ves_icall_System_Diagnostics_StackTrace_GetTrace,
// token 11491,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 11512,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 11514,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 11516,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_flags [] = {
0,
0,
0,
0,
4,
4,
0,
4,
4,
4,
0,
0,
0,
4,
4,
4,
4,
4,
0,
4,
0,
0,
0,
4,
4,
4,
4,
4,
0,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
0,
0,
0,
0,
};
