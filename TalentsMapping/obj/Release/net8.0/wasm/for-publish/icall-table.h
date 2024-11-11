#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
194,
204,
205,
206,
207,
208,
209,
210,
211,
212,
215,
216,
318,
319,
320,
349,
350,
351,
371,
372,
373,
374,
471,
472,
473,
476,
511,
512,
514,
516,
518,
520,
525,
533,
534,
535,
536,
537,
538,
539,
540,
541,
635,
636,
701,
707,
710,
712,
717,
718,
720,
721,
725,
726,
728,
730,
731,
734,
735,
736,
739,
741,
744,
746,
748,
757,
821,
823,
825,
835,
836,
837,
838,
840,
847,
848,
849,
850,
851,
859,
860,
861,
865,
866,
868,
872,
873,
874,
1153,
1329,
1330,
7267,
7268,
7270,
7271,
7272,
7273,
7274,
7276,
7278,
7280,
7288,
7290,
7295,
7297,
7299,
7301,
7352,
7353,
7355,
7356,
7357,
7358,
7359,
7361,
7363,
8335,
8339,
8341,
8342,
8343,
8344,
8593,
8594,
8595,
8596,
8614,
8615,
8616,
8618,
8660,
8719,
8721,
8723,
8732,
8733,
8734,
8735,
9127,
9132,
9133,
9160,
9178,
9185,
9192,
9203,
9207,
9227,
9300,
9302,
9311,
9313,
9314,
9321,
9335,
9355,
9356,
9364,
9366,
9373,
9374,
9377,
9379,
9384,
9390,
9391,
9398,
9400,
9412,
9415,
9416,
9417,
9428,
9437,
9443,
9444,
9445,
9447,
9448,
9465,
9467,
9481,
9498,
9525,
9555,
9556,
10039,
10131,
10132,
10334,
10335,
10342,
10343,
10344,
10349,
10424,
10811,
10812,
11034,
11044,
11822,
11843,
11845,
11847,
};
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal (int);
int ves_icall_System_Array_IsValueOfElementTypeInternal (int,int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy (int,int,int,int,int);
int ves_icall_System_Array_GetLengthInternal_raw (int,int,int);
int ves_icall_System_Array_GetLowerBoundInternal_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
void ves_icall_System_Array_GetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetGenericValue_icall (int,int,int);
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
int ves_icall_RuntimeTypeHandle_IsComObject_raw (int,int);
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
int ves_icall_System_String_InternalIsInterned_raw (int,int);
int ves_icall_System_String_InternalIntern_raw (int,int);
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
// token 194,
ves_icall_System_Array_InternalCreate,
// token 204,
ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal,
// token 205,
ves_icall_System_Array_IsValueOfElementTypeInternal,
// token 206,
ves_icall_System_Array_CanChangePrimitive,
// token 207,
ves_icall_System_Array_FastCopy,
// token 208,
ves_icall_System_Array_GetLengthInternal_raw,
// token 209,
ves_icall_System_Array_GetLowerBoundInternal_raw,
// token 210,
ves_icall_System_Array_GetGenericValue_icall,
// token 211,
ves_icall_System_Array_GetValueImpl_raw,
// token 212,
ves_icall_System_Array_SetGenericValue_icall,
// token 215,
ves_icall_System_Array_SetValueImpl_raw,
// token 216,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 318,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 319,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 320,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 349,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 350,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 351,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 371,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 372,
ves_icall_System_Enum_InternalBoxEnum_raw,
// token 373,
ves_icall_System_Enum_InternalGetCorElementType,
// token 374,
ves_icall_System_Enum_InternalGetUnderlyingType_raw,
// token 471,
ves_icall_System_Environment_get_ProcessorCount,
// token 472,
ves_icall_System_Environment_get_TickCount,
// token 473,
ves_icall_System_Environment_get_TickCount64,
// token 476,
ves_icall_System_Environment_FailFast_raw,
// token 511,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 512,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 514,
ves_icall_System_GC_SuppressFinalize_raw,
// token 516,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 518,
ves_icall_System_GC_GetGCMemoryInfo,
// token 520,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 525,
ves_icall_System_Object_MemberwiseClone_raw,
// token 533,
ves_icall_System_Math_Ceiling,
// token 534,
ves_icall_System_Math_Cos,
// token 535,
ves_icall_System_Math_Floor,
// token 536,
ves_icall_System_Math_Log10,
// token 537,
ves_icall_System_Math_Pow,
// token 538,
ves_icall_System_Math_Sin,
// token 539,
ves_icall_System_Math_Sqrt,
// token 540,
ves_icall_System_Math_Tan,
// token 541,
ves_icall_System_Math_ModF,
// token 635,
ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw,
// token 636,
ves_icall_RuntimeMethodHandle_ReboxToNullable_raw,
// token 701,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 707,
ves_icall_RuntimeType_make_array_type_raw,
// token 710,
ves_icall_RuntimeType_make_byref_type_raw,
// token 712,
ves_icall_RuntimeType_make_pointer_type_raw,
// token 717,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 718,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 720,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 721,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 725,
ves_icall_System_RuntimeType_CreateInstanceInternal_raw,
// token 726,
ves_icall_System_RuntimeType_AllocateValueType_raw,
// token 728,
ves_icall_RuntimeType_GetDeclaringMethod_raw,
// token 730,
ves_icall_System_RuntimeType_getFullName_raw,
// token 731,
ves_icall_RuntimeType_GetGenericArgumentsInternal_raw,
// token 734,
ves_icall_RuntimeType_GetGenericParameterPosition,
// token 735,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 736,
ves_icall_RuntimeType_GetFields_native_raw,
// token 739,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 741,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 744,
ves_icall_RuntimeType_GetDeclaringType_raw,
// token 746,
ves_icall_RuntimeType_GetName_raw,
// token 748,
ves_icall_RuntimeType_GetNamespace_raw,
// token 757,
ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw,
// token 821,
ves_icall_RuntimeTypeHandle_GetAttributes,
// token 823,
ves_icall_RuntimeTypeHandle_GetMetadataToken_raw,
// token 825,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 835,
ves_icall_RuntimeTypeHandle_GetCorElementType,
// token 836,
ves_icall_RuntimeTypeHandle_HasInstantiation,
// token 837,
ves_icall_RuntimeTypeHandle_IsComObject_raw,
// token 838,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 840,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 847,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 848,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 849,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 850,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 851,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 859,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 860,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition,
// token 861,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 865,
ves_icall_RuntimeTypeHandle_is_subclass_of_raw,
// token 866,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 868,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 872,
ves_icall_System_String_FastAllocateString_raw,
// token 873,
ves_icall_System_String_InternalIsInterned_raw,
// token 874,
ves_icall_System_String_InternalIntern_raw,
// token 1153,
ves_icall_System_Type_internal_from_handle_raw,
// token 1329,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1330,
ves_icall_System_ValueType_Equals_raw,
// token 7267,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 7268,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 7270,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 7271,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 7272,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 7273,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 7274,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 7276,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 7278,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 7280,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 7288,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 7290,
mono_monitor_exit_icall_raw,
// token 7295,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 7297,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 7299,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 7301,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 7352,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 7353,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 7355,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 7356,
ves_icall_System_Threading_Thread_GetState_raw,
// token 7357,
ves_icall_System_Threading_Thread_SetState_raw,
// token 7358,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 7359,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 7361,
ves_icall_System_Threading_Thread_YieldInternal,
// token 7363,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 8335,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 8339,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 8341,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 8342,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 8343,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 8344,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 8593,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 8594,
ves_icall_System_GCHandle_InternalFree_raw,
// token 8595,
ves_icall_System_GCHandle_InternalGet_raw,
// token 8596,
ves_icall_System_GCHandle_InternalSet_raw,
// token 8614,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 8615,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 8616,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 8618,
ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw,
// token 8660,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw,
// token 8719,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw,
// token 8721,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalTryGetHashCode_raw,
// token 8723,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 8732,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 8733,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 8734,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw,
// token 8735,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 9127,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 9132,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 9133,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 9160,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 9178,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 9185,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 9192,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 9203,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 9207,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 9227,
ves_icall_System_Reflection_LoaderAllocatorScout_Destroy,
// token 9300,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 9302,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 9311,
ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw,
// token 9313,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 9314,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 9321,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 9335,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 9355,
ves_icall_reflection_get_token_raw,
// token 9356,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 9364,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 9366,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 9373,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 9374,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 9377,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 9379,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 9384,
ves_icall_reflection_get_token_raw,
// token 9390,
ves_icall_get_method_info_raw,
// token 9391,
ves_icall_get_method_attributes,
// token 9398,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 9400,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 9412,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 9415,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 9416,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 9417,
ves_icall_reflection_get_token_raw,
// token 9428,
ves_icall_InternalInvoke_raw,
// token 9437,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 9443,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 9444,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 9445,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 9447,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 9448,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 9465,
ves_icall_InvokeClassConstructor_raw,
// token 9467,
ves_icall_InternalInvoke_raw,
// token 9481,
ves_icall_reflection_get_token_raw,
// token 9498,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 9525,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 9555,
ves_icall_reflection_get_token_raw,
// token 9556,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 10039,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 10131,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 10132,
ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw,
// token 10334,
ves_icall_ModuleBuilder_basic_init_raw,
// token 10335,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 10342,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 10343,
ves_icall_ModuleBuilder_getToken_raw,
// token 10344,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 10349,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 10424,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 10811,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 10812,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 11034,
ves_icall_System_Diagnostics_StackFrame_GetFrameInfo,
// token 11044,
ves_icall_System_Diagnostics_StackTrace_GetTrace,
// token 11822,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 11843,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 11845,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 11847,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_flags [] = {
0,
0,
0,
0,
0,
4,
4,
0,
4,
0,
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
