using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Interop.Config;
using InteropShared;

namespace RealmNet.Interop
{
    internal static class NativeTable
    {

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "row_get_row_index", CallingConvention = CallingConvention.Cdecl )]
        public static extern IntPtr row_get_row_index(RowHandle rowHandle);

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "row_get_is_attached",
            CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr row_get_is_attached(RowHandle rowHandle);

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "row_delete", CallingConvention = CallingConvention.Cdecl)]
        public static extern void row_delete(RowHandle rowHandle);

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "table_add_column", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr table_add_column(TableHandle tableHandle, IntPtr type,
            [MarshalAs(UnmanagedType.LPWStr)] string name, IntPtr nameLen);

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "table_add_empty_row", CallingConvention = CallingConvention.Cdecl)]
        internal static extern RowHandle table_add_empty_row(TableHandle tableHandle);

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "table_set_string", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void table_set_string(TableHandle tablePtr, IntPtr columnNdx, IntPtr rowNdx,
            [MarshalAs(UnmanagedType.LPWStr)] string value, IntPtr valueLen);

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "table_get_string", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr table_get_string(TableHandle handle, IntPtr columnIndex, IntPtr rowIndex,
            IntPtr buffer, IntPtr bufsize);

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "table_set_bool", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void table_set_bool(TableHandle tablePtr, IntPtr columnNdx, IntPtr rowNdx, IntPtr value);

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "table_get_bool", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr table_get_bool(TableHandle handle, IntPtr columnIndex, IntPtr rowIndex);

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "table_set_int64", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void table_set_int64(TableHandle tablePtr, IntPtr columnNdx, IntPtr rowNdx, Int64 value);

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "table_get_int64", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int64 table_get_int64(TableHandle handle, IntPtr columnIndex, IntPtr rowIndex);

        public static void table_set_float(TableHandle TableHandle, long columnIndex, long rowIndex, float value)
        {
            throw new NotImplementedException();
        }

        public static float table_get_float(TableHandle TableHandle, long columnIndex, long rowIndex)
        {
            throw new NotImplementedException();
        }

        public static void table_set_double(TableHandle TableHandle, long columnIndex, long rowIndex, double value)
        {
            throw new NotImplementedException();
        }

        public static double table_get_double(TableHandle TableHandle, long columnIndex, long rowIndex)
        {
            throw new NotImplementedException();
        }

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "table_where", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr table_where(TableHandle handle);

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "table_unbind", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void table_unbind(TableHandle tableHandle);

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "table_remove_row", CallingConvention = CallingConvention.Cdecl)]
        public static extern void table_remove_row(TableHandle tableHandle, RowHandle rowHandle);

        [DllImport(InteropConfig.DLL_NAME, EntryPoint = "table_get_column_index", CallingConvention = CallingConvention.Cdecl)]
         //returns -1 if the column string does not match a column index
       internal static extern IntPtr table_get_column_index(TableHandle tablehandle,
            [MarshalAs(UnmanagedType.LPWStr)] string name, IntPtr nameLen);

	}
}