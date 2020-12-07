// Automatically generated file
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

#pragma warning disable 1591

namespace Microsoft.Z3
{
    using Z3_config = System.IntPtr;
    using Z3_context = System.IntPtr;
    using Z3_ast = System.IntPtr;
    using Z3_app = System.IntPtr;
    using Z3_sort = System.IntPtr;
    using Z3_func_decl = System.IntPtr;
    using Z3_pattern = System.IntPtr;
    using Z3_model = System.IntPtr;
    using Z3_literals = System.IntPtr;
    using Z3_constructor = System.IntPtr;
    using Z3_constructor_list = System.IntPtr;
    using Z3_solver = System.IntPtr;
    using Z3_goal = System.IntPtr;
    using Z3_tactic = System.IntPtr;
    using Z3_params = System.IntPtr;
    using Z3_probe = System.IntPtr;
    using Z3_stats = System.IntPtr;
    using Z3_ast_vector = System.IntPtr;
    using Z3_ast_map = System.IntPtr;
    using Z3_apply_result = System.IntPtr;
    using Z3_func_interp = System.IntPtr;
    using Z3_func_entry = System.IntPtr;
    using Z3_fixedpoint = System.IntPtr;
    using Z3_optimize = System.IntPtr;
    using Z3_param_descrs = System.IntPtr;
    using Z3_rcf_num = System.IntPtr;

    public class Native
    {

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void Z3_error_handler(Z3_context c, Z3_error_code e);

        public class LIB
        {
            const string Z3_DLL_NAME = "libz3.so";
            
            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_set_error_handler(Z3_context a0, Z3_error_handler a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_global_param_set(string a0, string a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_global_param_reset_all();

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_global_param_get(string a0, out IntPtr a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_config Z3_mk_config();

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_del_config(Z3_config a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_set_param_value(Z3_config a0, string a1, string a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_context Z3_mk_context(Z3_config a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_context Z3_mk_context_rc(Z3_config a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_del_context(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_inc_ref(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_dec_ref(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_update_param_value(Z3_context a0, string a1, string a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_interrupt(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_params Z3_mk_params(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_params_inc_ref(Z3_context a0, Z3_params a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_params_dec_ref(Z3_context a0, Z3_params a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_params_set_bool(Z3_context a0, Z3_params a1, IntPtr a2, byte a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_params_set_uint(Z3_context a0, Z3_params a1, IntPtr a2, uint a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_params_set_double(Z3_context a0, Z3_params a1, IntPtr a2, double a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_params_set_symbol(Z3_context a0, Z3_params a1, IntPtr a2, IntPtr a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_params_to_string(Z3_context a0, Z3_params a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_params_validate(Z3_context a0, Z3_params a1, Z3_param_descrs a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_param_descrs_inc_ref(Z3_context a0, Z3_param_descrs a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_param_descrs_dec_ref(Z3_context a0, Z3_param_descrs a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_param_descrs_get_kind(Z3_context a0, Z3_param_descrs a1, IntPtr a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_param_descrs_size(Z3_context a0, Z3_param_descrs a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_param_descrs_get_name(Z3_context a0, Z3_param_descrs a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_param_descrs_get_documentation(Z3_context a0, Z3_param_descrs a1, IntPtr a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_param_descrs_to_string(Z3_context a0, Z3_param_descrs a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_mk_int_symbol(Z3_context a0, int a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_mk_string_symbol(Z3_context a0, string a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_uninterpreted_sort(Z3_context a0, IntPtr a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_bool_sort(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_int_sort(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_real_sort(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_bv_sort(Z3_context a0, uint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_finite_domain_sort(Z3_context a0, IntPtr a1, UInt64 a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_array_sort(Z3_context a0, Z3_sort a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_array_sort_n(Z3_context a0, uint a1, [In] Z3_sort[] a2, Z3_sort a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_tuple_sort(Z3_context a0, IntPtr a1, uint a2, [In] IntPtr[] a3, [In] Z3_sort[] a4, [In, Out] ref Z3_func_decl a5, [Out] Z3_func_decl[] a6);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_enumeration_sort(Z3_context a0, IntPtr a1, uint a2, [In] IntPtr[] a3, [Out] Z3_func_decl[] a4, [Out] Z3_func_decl[] a5);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_list_sort(Z3_context a0, IntPtr a1, Z3_sort a2, [In, Out] ref Z3_func_decl a3, [In, Out] ref Z3_func_decl a4, [In, Out] ref Z3_func_decl a5, [In, Out] ref Z3_func_decl a6, [In, Out] ref Z3_func_decl a7, [In, Out] ref Z3_func_decl a8);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_constructor Z3_mk_constructor(Z3_context a0, IntPtr a1, IntPtr a2, uint a3, [In] IntPtr[] a4, [In] Z3_sort[] a5, [In] uint[] a6);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_del_constructor(Z3_context a0, Z3_constructor a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_datatype(Z3_context a0, IntPtr a1, uint a2, [In, Out] Z3_constructor[] a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_constructor_list Z3_mk_constructor_list(Z3_context a0, uint a1, [In] Z3_constructor[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_del_constructor_list(Z3_context a0, Z3_constructor_list a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_mk_datatypes(Z3_context a0, uint a1, [In] IntPtr[] a2, [Out] Z3_sort[] a3, [In, Out] Z3_constructor_list[] a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_query_constructor(Z3_context a0, Z3_constructor a1, uint a2, [In, Out] ref Z3_func_decl a3, [In, Out] ref Z3_func_decl a4, [Out] Z3_func_decl[] a5);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_mk_func_decl(Z3_context a0, IntPtr a1, uint a2, [In] Z3_sort[] a3, Z3_sort a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_app(Z3_context a0, Z3_func_decl a1, uint a2, [In] Z3_ast[] a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_const(Z3_context a0, IntPtr a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_mk_fresh_func_decl(Z3_context a0, string a1, uint a2, [In] Z3_sort[] a3, Z3_sort a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fresh_const(Z3_context a0, string a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_mk_rec_func_decl(Z3_context a0, IntPtr a1, uint a2, [In] Z3_sort[] a3, Z3_sort a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_add_rec_def(Z3_context a0, Z3_func_decl a1, uint a2, [In] Z3_ast[] a3, Z3_ast a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_true(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_false(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_eq(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_distinct(Z3_context a0, uint a1, [In] Z3_ast[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_not(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_ite(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_iff(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_implies(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_xor(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_and(Z3_context a0, uint a1, [In] Z3_ast[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_or(Z3_context a0, uint a1, [In] Z3_ast[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_add(Z3_context a0, uint a1, [In] Z3_ast[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_mul(Z3_context a0, uint a1, [In] Z3_ast[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_sub(Z3_context a0, uint a1, [In] Z3_ast[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_unary_minus(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_div(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_mod(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_rem(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_power(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_lt(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_le(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_gt(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_ge(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_divides(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_int2real(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_real2int(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_is_int(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvnot(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvredand(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvredor(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvand(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvor(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvxor(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvnand(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvnor(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvxnor(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvneg(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvadd(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvsub(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvmul(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvudiv(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvsdiv(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvurem(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvsrem(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvsmod(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvult(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvslt(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvule(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvsle(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvuge(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvsge(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvugt(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvsgt(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_concat(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_extract(Z3_context a0, uint a1, uint a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_sign_ext(Z3_context a0, uint a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_zero_ext(Z3_context a0, uint a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_repeat(Z3_context a0, uint a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvshl(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvlshr(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvashr(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_rotate_left(Z3_context a0, uint a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_rotate_right(Z3_context a0, uint a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_ext_rotate_left(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_ext_rotate_right(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_int2bv(Z3_context a0, uint a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bv2int(Z3_context a0, Z3_ast a1, byte a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvadd_no_overflow(Z3_context a0, Z3_ast a1, Z3_ast a2, byte a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvadd_no_underflow(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvsub_no_overflow(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvsub_no_underflow(Z3_context a0, Z3_ast a1, Z3_ast a2, byte a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvsdiv_no_overflow(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvneg_no_overflow(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvmul_no_overflow(Z3_context a0, Z3_ast a1, Z3_ast a2, byte a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bvmul_no_underflow(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_select(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_select_n(Z3_context a0, Z3_ast a1, uint a2, [In] Z3_ast[] a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_store(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_store_n(Z3_context a0, Z3_ast a1, uint a2, [In] Z3_ast[] a3, Z3_ast a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_const_array(Z3_context a0, Z3_sort a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_map(Z3_context a0, Z3_func_decl a1, uint a2, [In] Z3_ast[] a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_array_default(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_as_array(Z3_context a0, Z3_func_decl a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_set_has_size(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_set_sort(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_empty_set(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_full_set(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_set_add(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_set_del(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_set_union(Z3_context a0, uint a1, [In] Z3_ast[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_set_intersect(Z3_context a0, uint a1, [In] Z3_ast[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_set_difference(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_set_complement(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_set_member(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_set_subset(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_array_ext(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_numeral(Z3_context a0, string a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_real(Z3_context a0, int a1, int a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_int(Z3_context a0, int a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_unsigned_int(Z3_context a0, uint a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_int64(Z3_context a0, Int64 a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_unsigned_int64(Z3_context a0, UInt64 a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bv_numeral(Z3_context a0, uint a1, [In] byte[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_seq_sort(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_seq_sort(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_get_seq_sort_basis(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_re_sort(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_re_sort(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_get_re_sort_basis(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_string_sort(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_string_sort(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_string(Z3_context a0, string a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_lstring(Z3_context a0, uint a1, string a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_string(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_get_string(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_get_lstring(Z3_context a0, Z3_ast a1, [In, Out] ref uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_empty(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_unit(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_concat(Z3_context a0, uint a1, [In] Z3_ast[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_prefix(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_suffix(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_contains(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_str_lt(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_str_le(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_extract(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_replace(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_at(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_nth(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_length(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_index(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_last_index(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_str_to_int(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_int_to_str(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_to_re(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_seq_in_re(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_re_plus(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_re_star(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_re_option(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_re_union(Z3_context a0, uint a1, [In] Z3_ast[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_re_concat(Z3_context a0, uint a1, [In] Z3_ast[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_re_range(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_re_loop(Z3_context a0, Z3_ast a1, uint a2, uint a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_re_intersect(Z3_context a0, uint a1, [In] Z3_ast[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_re_complement(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_re_empty(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_re_full(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_mk_linear_order(Z3_context a0, Z3_sort a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_mk_partial_order(Z3_context a0, Z3_sort a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_mk_piecewise_linear_order(Z3_context a0, Z3_sort a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_mk_tree_order(Z3_context a0, Z3_sort a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_mk_transitive_closure(Z3_context a0, Z3_func_decl a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_pattern Z3_mk_pattern(Z3_context a0, uint a1, [In] Z3_ast[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_bound(Z3_context a0, uint a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_forall(Z3_context a0, uint a1, uint a2, [In] Z3_pattern[] a3, uint a4, [In] Z3_sort[] a5, [In] IntPtr[] a6, Z3_ast a7);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_exists(Z3_context a0, uint a1, uint a2, [In] Z3_pattern[] a3, uint a4, [In] Z3_sort[] a5, [In] IntPtr[] a6, Z3_ast a7);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_quantifier(Z3_context a0, byte a1, uint a2, uint a3, [In] Z3_pattern[] a4, uint a5, [In] Z3_sort[] a6, [In] IntPtr[] a7, Z3_ast a8);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_quantifier_ex(Z3_context a0, byte a1, uint a2, IntPtr a3, IntPtr a4, uint a5, [In] Z3_pattern[] a6, uint a7, [In] Z3_ast[] a8, uint a9, [In] Z3_sort[] a10, [In] IntPtr[] a11, Z3_ast a12);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_forall_const(Z3_context a0, uint a1, uint a2, [In] Z3_app[] a3, uint a4, [In] Z3_pattern[] a5, Z3_ast a6);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_exists_const(Z3_context a0, uint a1, uint a2, [In] Z3_app[] a3, uint a4, [In] Z3_pattern[] a5, Z3_ast a6);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_quantifier_const(Z3_context a0, byte a1, uint a2, uint a3, [In] Z3_app[] a4, uint a5, [In] Z3_pattern[] a6, Z3_ast a7);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_quantifier_const_ex(Z3_context a0, byte a1, uint a2, IntPtr a3, IntPtr a4, uint a5, [In] Z3_app[] a6, uint a7, [In] Z3_pattern[] a8, uint a9, [In] Z3_ast[] a10, Z3_ast a11);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_lambda(Z3_context a0, uint a1, [In] Z3_sort[] a2, [In] IntPtr[] a3, Z3_ast a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_lambda_const(Z3_context a0, uint a1, [In] Z3_app[] a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_symbol_kind(Z3_context a0, IntPtr a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static int Z3_get_symbol_int(Z3_context a0, IntPtr a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_get_symbol_string(Z3_context a0, IntPtr a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_get_sort_name(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_sort_id(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_sort_to_ast(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_eq_sort(Z3_context a0, Z3_sort a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_sort_kind(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_bv_sort_size(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_get_finite_domain_sort_size(Z3_context a0, Z3_sort a1, [In, Out] ref UInt64 a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_get_array_sort_domain(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_get_array_sort_range(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_get_tuple_sort_mk_decl(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_tuple_sort_num_fields(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_get_tuple_sort_field_decl(Z3_context a0, Z3_sort a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_datatype_sort_num_constructors(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_get_datatype_sort_constructor(Z3_context a0, Z3_sort a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_get_datatype_sort_recognizer(Z3_context a0, Z3_sort a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_get_datatype_sort_constructor_accessor(Z3_context a0, Z3_sort a1, uint a2, uint a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_datatype_update_field(Z3_context a0, Z3_func_decl a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_relation_arity(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_get_relation_column(Z3_context a0, Z3_sort a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_atmost(Z3_context a0, uint a1, [In] Z3_ast[] a2, uint a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_atleast(Z3_context a0, uint a1, [In] Z3_ast[] a2, uint a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_pble(Z3_context a0, uint a1, [In] Z3_ast[] a2, [In] int[] a3, int a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_pbge(Z3_context a0, uint a1, [In] Z3_ast[] a2, [In] int[] a3, int a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_pbeq(Z3_context a0, uint a1, [In] Z3_ast[] a2, [In] int[] a3, int a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_func_decl_to_ast(Z3_context a0, Z3_func_decl a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_eq_func_decl(Z3_context a0, Z3_func_decl a1, Z3_func_decl a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_func_decl_id(Z3_context a0, Z3_func_decl a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_get_decl_name(Z3_context a0, Z3_func_decl a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_decl_kind(Z3_context a0, Z3_func_decl a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_domain_size(Z3_context a0, Z3_func_decl a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_arity(Z3_context a0, Z3_func_decl a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_get_domain(Z3_context a0, Z3_func_decl a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_get_range(Z3_context a0, Z3_func_decl a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_decl_num_parameters(Z3_context a0, Z3_func_decl a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_decl_parameter_kind(Z3_context a0, Z3_func_decl a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static int Z3_get_decl_int_parameter(Z3_context a0, Z3_func_decl a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static double Z3_get_decl_double_parameter(Z3_context a0, Z3_func_decl a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_get_decl_symbol_parameter(Z3_context a0, Z3_func_decl a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_get_decl_sort_parameter(Z3_context a0, Z3_func_decl a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_get_decl_ast_parameter(Z3_context a0, Z3_func_decl a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_get_decl_func_decl_parameter(Z3_context a0, Z3_func_decl a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_get_decl_rational_parameter(Z3_context a0, Z3_func_decl a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_app_to_ast(Z3_context a0, Z3_app a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_get_app_decl(Z3_context a0, Z3_app a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_app_num_args(Z3_context a0, Z3_app a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_get_app_arg(Z3_context a0, Z3_app a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_eq_ast(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_ast_id(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_ast_hash(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_get_sort(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_well_sorted(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static int Z3_get_bool_value(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_ast_kind(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_app(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_numeral_ast(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_algebraic_number(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_app Z3_to_app(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_to_func_decl(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_get_numeral_string(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_get_numeral_decimal_string(Z3_context a0, Z3_ast a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static double Z3_get_numeral_double(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_get_numerator(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_get_denominator(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_get_numeral_small(Z3_context a0, Z3_ast a1, [In, Out] ref Int64 a2, [In, Out] ref Int64 a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_get_numeral_int(Z3_context a0, Z3_ast a1, [In, Out] ref int a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_get_numeral_uint(Z3_context a0, Z3_ast a1, [In, Out] ref uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_get_numeral_uint64(Z3_context a0, Z3_ast a1, [In, Out] ref UInt64 a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_get_numeral_int64(Z3_context a0, Z3_ast a1, [In, Out] ref Int64 a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_get_numeral_rational_int64(Z3_context a0, Z3_ast a1, [In, Out] ref Int64 a2, [In, Out] ref Int64 a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_get_algebraic_number_lower(Z3_context a0, Z3_ast a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_get_algebraic_number_upper(Z3_context a0, Z3_ast a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_pattern_to_ast(Z3_context a0, Z3_pattern a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_pattern_num_terms(Z3_context a0, Z3_pattern a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_get_pattern(Z3_context a0, Z3_pattern a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_index_value(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_quantifier_forall(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_quantifier_exists(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_lambda(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_quantifier_weight(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_quantifier_num_patterns(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_pattern Z3_get_quantifier_pattern_ast(Z3_context a0, Z3_ast a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_quantifier_num_no_patterns(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_get_quantifier_no_pattern_ast(Z3_context a0, Z3_ast a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_quantifier_num_bound(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_get_quantifier_bound_name(Z3_context a0, Z3_ast a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_get_quantifier_bound_sort(Z3_context a0, Z3_ast a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_get_quantifier_body(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_simplify(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_simplify_ex(Z3_context a0, Z3_ast a1, Z3_params a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_simplify_get_help(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_param_descrs Z3_simplify_get_param_descrs(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_update_term(Z3_context a0, Z3_ast a1, uint a2, [In] Z3_ast[] a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_substitute(Z3_context a0, Z3_ast a1, uint a2, [In] Z3_ast[] a3, [In] Z3_ast[] a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_substitute_vars(Z3_context a0, Z3_ast a1, uint a2, [In] Z3_ast[] a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_translate(Z3_context a0, Z3_ast a1, Z3_context a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_model Z3_mk_model(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_model_inc_ref(Z3_context a0, Z3_model a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_model_dec_ref(Z3_context a0, Z3_model a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_model_eval(Z3_context a0, Z3_model a1, Z3_ast a2, byte a3, [In, Out] ref Z3_ast a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_model_get_const_interp(Z3_context a0, Z3_model a1, Z3_func_decl a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_model_has_interp(Z3_context a0, Z3_model a1, Z3_func_decl a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_interp Z3_model_get_func_interp(Z3_context a0, Z3_model a1, Z3_func_decl a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_model_get_num_consts(Z3_context a0, Z3_model a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_model_get_const_decl(Z3_context a0, Z3_model a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_model_get_num_funcs(Z3_context a0, Z3_model a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_model_get_func_decl(Z3_context a0, Z3_model a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_model_get_num_sorts(Z3_context a0, Z3_model a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_model_get_sort(Z3_context a0, Z3_model a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_model_get_sort_universe(Z3_context a0, Z3_model a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_model Z3_model_translate(Z3_context a0, Z3_model a1, Z3_context a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_is_as_array(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_decl Z3_get_as_array_func_decl(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_interp Z3_add_func_interp(Z3_context a0, Z3_model a1, Z3_func_decl a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_add_const_interp(Z3_context a0, Z3_model a1, Z3_func_decl a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_func_interp_inc_ref(Z3_context a0, Z3_func_interp a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_func_interp_dec_ref(Z3_context a0, Z3_func_interp a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_func_interp_get_num_entries(Z3_context a0, Z3_func_interp a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_func_entry Z3_func_interp_get_entry(Z3_context a0, Z3_func_interp a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_func_interp_get_else(Z3_context a0, Z3_func_interp a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_func_interp_set_else(Z3_context a0, Z3_func_interp a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_func_interp_get_arity(Z3_context a0, Z3_func_interp a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_func_interp_add_entry(Z3_context a0, Z3_func_interp a1, Z3_ast_vector a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_func_entry_inc_ref(Z3_context a0, Z3_func_entry a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_func_entry_dec_ref(Z3_context a0, Z3_func_entry a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_func_entry_get_value(Z3_context a0, Z3_func_entry a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_func_entry_get_num_args(Z3_context a0, Z3_func_entry a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_func_entry_get_arg(Z3_context a0, Z3_func_entry a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static int Z3_open_log(string a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_append_log(string a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_close_log();

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_toggle_warning_messages(byte a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_set_ast_print_mode(Z3_context a0, uint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_ast_to_string(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_pattern_to_string(Z3_context a0, Z3_pattern a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_sort_to_string(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_func_decl_to_string(Z3_context a0, Z3_func_decl a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_model_to_string(Z3_context a0, Z3_model a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_benchmark_to_smtlib_string(Z3_context a0, string a1, string a2, string a3, string a4, uint a5, [In] Z3_ast[] a6, Z3_ast a7);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_parse_smtlib2_string(Z3_context a0, string a1, uint a2, [In] IntPtr[] a3, [In] Z3_sort[] a4, uint a5, [In] IntPtr[] a6, [In] Z3_func_decl[] a7);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_parse_smtlib2_file(Z3_context a0, string a1, uint a2, [In] IntPtr[] a3, [In] Z3_sort[] a4, uint a5, [In] IntPtr[] a6, [In] Z3_func_decl[] a7);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_eval_smtlib2_string(Z3_context a0, string a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_error_code(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_set_error(Z3_context a0, uint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_get_error_msg(Z3_context a0, uint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_get_version([In, Out] ref uint a0, [In, Out] ref uint a1, [In, Out] ref uint a2, [In, Out] ref uint a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_get_full_version();

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_enable_trace(string a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_disable_trace(string a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_reset_memory();

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_finalize_memory();

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_goal Z3_mk_goal(Z3_context a0, byte a1, byte a2, byte a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_goal_inc_ref(Z3_context a0, Z3_goal a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_goal_dec_ref(Z3_context a0, Z3_goal a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_goal_precision(Z3_context a0, Z3_goal a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_goal_assert(Z3_context a0, Z3_goal a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_goal_inconsistent(Z3_context a0, Z3_goal a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_goal_depth(Z3_context a0, Z3_goal a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_goal_reset(Z3_context a0, Z3_goal a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_goal_size(Z3_context a0, Z3_goal a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_goal_formula(Z3_context a0, Z3_goal a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_goal_num_exprs(Z3_context a0, Z3_goal a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_goal_is_decided_sat(Z3_context a0, Z3_goal a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_goal_is_decided_unsat(Z3_context a0, Z3_goal a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_goal Z3_goal_translate(Z3_context a0, Z3_goal a1, Z3_context a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_model Z3_goal_convert_model(Z3_context a0, Z3_goal a1, Z3_model a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_goal_to_string(Z3_context a0, Z3_goal a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_goal_to_dimacs_string(Z3_context a0, Z3_goal a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_tactic Z3_mk_tactic(Z3_context a0, string a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_tactic_inc_ref(Z3_context a0, Z3_tactic a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_tactic_dec_ref(Z3_context a0, Z3_tactic a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_probe Z3_mk_probe(Z3_context a0, string a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_probe_inc_ref(Z3_context a0, Z3_probe a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_probe_dec_ref(Z3_context a0, Z3_probe a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_tactic Z3_tactic_and_then(Z3_context a0, Z3_tactic a1, Z3_tactic a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_tactic Z3_tactic_or_else(Z3_context a0, Z3_tactic a1, Z3_tactic a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_tactic Z3_tactic_par_or(Z3_context a0, uint a1, [In] Z3_tactic[] a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_tactic Z3_tactic_par_and_then(Z3_context a0, Z3_tactic a1, Z3_tactic a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_tactic Z3_tactic_try_for(Z3_context a0, Z3_tactic a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_tactic Z3_tactic_when(Z3_context a0, Z3_probe a1, Z3_tactic a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_tactic Z3_tactic_cond(Z3_context a0, Z3_probe a1, Z3_tactic a2, Z3_tactic a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_tactic Z3_tactic_repeat(Z3_context a0, Z3_tactic a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_tactic Z3_tactic_skip(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_tactic Z3_tactic_fail(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_tactic Z3_tactic_fail_if(Z3_context a0, Z3_probe a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_tactic Z3_tactic_fail_if_not_decided(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_tactic Z3_tactic_using_params(Z3_context a0, Z3_tactic a1, Z3_params a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_probe Z3_probe_const(Z3_context a0, double a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_probe Z3_probe_lt(Z3_context a0, Z3_probe a1, Z3_probe a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_probe Z3_probe_gt(Z3_context a0, Z3_probe a1, Z3_probe a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_probe Z3_probe_le(Z3_context a0, Z3_probe a1, Z3_probe a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_probe Z3_probe_ge(Z3_context a0, Z3_probe a1, Z3_probe a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_probe Z3_probe_eq(Z3_context a0, Z3_probe a1, Z3_probe a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_probe Z3_probe_and(Z3_context a0, Z3_probe a1, Z3_probe a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_probe Z3_probe_or(Z3_context a0, Z3_probe a1, Z3_probe a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_probe Z3_probe_not(Z3_context a0, Z3_probe a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_num_tactics(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_get_tactic_name(Z3_context a0, uint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_get_num_probes(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_get_probe_name(Z3_context a0, uint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_tactic_get_help(Z3_context a0, Z3_tactic a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_param_descrs Z3_tactic_get_param_descrs(Z3_context a0, Z3_tactic a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_tactic_get_descr(Z3_context a0, string a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_probe_get_descr(Z3_context a0, string a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static double Z3_probe_apply(Z3_context a0, Z3_probe a1, Z3_goal a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_apply_result Z3_tactic_apply(Z3_context a0, Z3_tactic a1, Z3_goal a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_apply_result Z3_tactic_apply_ex(Z3_context a0, Z3_tactic a1, Z3_goal a2, Z3_params a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_apply_result_inc_ref(Z3_context a0, Z3_apply_result a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_apply_result_dec_ref(Z3_context a0, Z3_apply_result a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_apply_result_to_string(Z3_context a0, Z3_apply_result a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_apply_result_get_num_subgoals(Z3_context a0, Z3_apply_result a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_goal Z3_apply_result_get_subgoal(Z3_context a0, Z3_apply_result a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_solver Z3_mk_solver(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_solver Z3_mk_simple_solver(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_solver Z3_mk_solver_for_logic(Z3_context a0, IntPtr a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_solver Z3_mk_solver_from_tactic(Z3_context a0, Z3_tactic a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_solver Z3_solver_translate(Z3_context a0, Z3_solver a1, Z3_context a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_solver_import_model_converter(Z3_context a0, Z3_solver a1, Z3_solver a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_solver_get_help(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_param_descrs Z3_solver_get_param_descrs(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_solver_set_params(Z3_context a0, Z3_solver a1, Z3_params a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_solver_inc_ref(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_solver_dec_ref(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_solver_interrupt(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_solver_push(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_solver_pop(Z3_context a0, Z3_solver a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_solver_reset(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_solver_get_num_scopes(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_solver_assert(Z3_context a0, Z3_solver a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_solver_assert_and_track(Z3_context a0, Z3_solver a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_solver_from_file(Z3_context a0, Z3_solver a1, string a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_solver_from_string(Z3_context a0, Z3_solver a1, string a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_solver_get_assertions(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_solver_get_units(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_solver_get_trail(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_solver_get_non_units(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_solver_get_levels(Z3_context a0, Z3_solver a1, Z3_ast_vector a2, uint a3, [In] uint[] a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static int Z3_solver_check(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static int Z3_solver_check_assumptions(Z3_context a0, Z3_solver a1, uint a2, [In] Z3_ast[] a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static int Z3_get_implied_equalities(Z3_context a0, Z3_solver a1, uint a2, [In] Z3_ast[] a3, [Out] uint[] a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static int Z3_solver_get_consequences(Z3_context a0, Z3_solver a1, Z3_ast_vector a2, Z3_ast_vector a3, Z3_ast_vector a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_solver_cube(Z3_context a0, Z3_solver a1, Z3_ast_vector a2, uint a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_model Z3_solver_get_model(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_solver_get_proof(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_solver_get_unsat_core(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_solver_get_reason_unknown(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_stats Z3_solver_get_statistics(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_solver_to_string(Z3_context a0, Z3_solver a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_solver_to_dimacs_string(Z3_context a0, Z3_solver a1, byte a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_stats_to_string(Z3_context a0, Z3_stats a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_stats_inc_ref(Z3_context a0, Z3_stats a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_stats_dec_ref(Z3_context a0, Z3_stats a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_stats_size(Z3_context a0, Z3_stats a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_stats_get_key(Z3_context a0, Z3_stats a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_stats_is_uint(Z3_context a0, Z3_stats a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_stats_is_double(Z3_context a0, Z3_stats a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_stats_get_uint_value(Z3_context a0, Z3_stats a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static double Z3_stats_get_double_value(Z3_context a0, Z3_stats a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static UInt64 Z3_get_estimated_alloc_size();

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_mk_ast_vector(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_ast_vector_inc_ref(Z3_context a0, Z3_ast_vector a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_ast_vector_dec_ref(Z3_context a0, Z3_ast_vector a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_ast_vector_size(Z3_context a0, Z3_ast_vector a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_ast_vector_get(Z3_context a0, Z3_ast_vector a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_ast_vector_set(Z3_context a0, Z3_ast_vector a1, uint a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_ast_vector_resize(Z3_context a0, Z3_ast_vector a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_ast_vector_push(Z3_context a0, Z3_ast_vector a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_ast_vector_translate(Z3_context a0, Z3_ast_vector a1, Z3_context a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_ast_vector_to_string(Z3_context a0, Z3_ast_vector a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_map Z3_mk_ast_map(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_ast_map_inc_ref(Z3_context a0, Z3_ast_map a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_ast_map_dec_ref(Z3_context a0, Z3_ast_map a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_ast_map_contains(Z3_context a0, Z3_ast_map a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_ast_map_find(Z3_context a0, Z3_ast_map a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_ast_map_insert(Z3_context a0, Z3_ast_map a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_ast_map_erase(Z3_context a0, Z3_ast_map a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_ast_map_reset(Z3_context a0, Z3_ast_map a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_ast_map_size(Z3_context a0, Z3_ast_map a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_ast_map_keys(Z3_context a0, Z3_ast_map a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_ast_map_to_string(Z3_context a0, Z3_ast_map a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_algebraic_is_value(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_algebraic_is_pos(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_algebraic_is_neg(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_algebraic_is_zero(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static int Z3_algebraic_sign(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_algebraic_add(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_algebraic_sub(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_algebraic_mul(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_algebraic_div(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_algebraic_root(Z3_context a0, Z3_ast a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_algebraic_power(Z3_context a0, Z3_ast a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_algebraic_lt(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_algebraic_gt(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_algebraic_le(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_algebraic_ge(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_algebraic_eq(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_algebraic_neq(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_algebraic_roots(Z3_context a0, Z3_ast a1, uint a2, [In] Z3_ast[] a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static int Z3_algebraic_eval(Z3_context a0, Z3_ast a1, uint a2, [In] Z3_ast[] a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_algebraic_get_poly(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_algebraic_get_i(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_polynomial_subresultants(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_rcf_del(Z3_context a0, Z3_rcf_num a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_rcf_num Z3_rcf_mk_rational(Z3_context a0, string a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_rcf_num Z3_rcf_mk_small_int(Z3_context a0, int a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_rcf_num Z3_rcf_mk_pi(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_rcf_num Z3_rcf_mk_e(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_rcf_num Z3_rcf_mk_infinitesimal(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_rcf_mk_roots(Z3_context a0, uint a1, [In] Z3_rcf_num[] a2, [Out] Z3_rcf_num[] a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_rcf_num Z3_rcf_add(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_rcf_num Z3_rcf_sub(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_rcf_num Z3_rcf_mul(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_rcf_num Z3_rcf_div(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_rcf_num Z3_rcf_neg(Z3_context a0, Z3_rcf_num a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_rcf_num Z3_rcf_inv(Z3_context a0, Z3_rcf_num a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_rcf_num Z3_rcf_power(Z3_context a0, Z3_rcf_num a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_rcf_lt(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_rcf_gt(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_rcf_le(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_rcf_ge(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_rcf_eq(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_rcf_neq(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_rcf_num_to_string(Z3_context a0, Z3_rcf_num a1, byte a2, byte a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_rcf_num_to_decimal_string(Z3_context a0, Z3_rcf_num a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_rcf_get_numerator_denominator(Z3_context a0, Z3_rcf_num a1, [In, Out] ref Z3_rcf_num a2, [In, Out] ref Z3_rcf_num a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_fixedpoint Z3_mk_fixedpoint(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_fixedpoint_inc_ref(Z3_context a0, Z3_fixedpoint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_fixedpoint_dec_ref(Z3_context a0, Z3_fixedpoint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_fixedpoint_add_rule(Z3_context a0, Z3_fixedpoint a1, Z3_ast a2, IntPtr a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_fixedpoint_add_fact(Z3_context a0, Z3_fixedpoint a1, Z3_func_decl a2, uint a3, [In] uint[] a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_fixedpoint_assert(Z3_context a0, Z3_fixedpoint a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static int Z3_fixedpoint_query(Z3_context a0, Z3_fixedpoint a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static int Z3_fixedpoint_query_relations(Z3_context a0, Z3_fixedpoint a1, uint a2, [In] Z3_func_decl[] a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_fixedpoint_get_answer(Z3_context a0, Z3_fixedpoint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_fixedpoint_get_reason_unknown(Z3_context a0, Z3_fixedpoint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_fixedpoint_update_rule(Z3_context a0, Z3_fixedpoint a1, Z3_ast a2, IntPtr a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_fixedpoint_get_num_levels(Z3_context a0, Z3_fixedpoint a1, Z3_func_decl a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_fixedpoint_get_cover_delta(Z3_context a0, Z3_fixedpoint a1, int a2, Z3_func_decl a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_fixedpoint_add_cover(Z3_context a0, Z3_fixedpoint a1, int a2, Z3_func_decl a3, Z3_ast a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_stats Z3_fixedpoint_get_statistics(Z3_context a0, Z3_fixedpoint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_fixedpoint_register_relation(Z3_context a0, Z3_fixedpoint a1, Z3_func_decl a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_fixedpoint_set_predicate_representation(Z3_context a0, Z3_fixedpoint a1, Z3_func_decl a2, uint a3, [In] IntPtr[] a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_fixedpoint_get_rules(Z3_context a0, Z3_fixedpoint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_fixedpoint_get_assertions(Z3_context a0, Z3_fixedpoint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_fixedpoint_set_params(Z3_context a0, Z3_fixedpoint a1, Z3_params a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_fixedpoint_get_help(Z3_context a0, Z3_fixedpoint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_param_descrs Z3_fixedpoint_get_param_descrs(Z3_context a0, Z3_fixedpoint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_fixedpoint_to_string(Z3_context a0, Z3_fixedpoint a1, uint a2, [In] Z3_ast[] a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_fixedpoint_from_string(Z3_context a0, Z3_fixedpoint a1, string a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_fixedpoint_from_file(Z3_context a0, Z3_fixedpoint a1, string a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_optimize Z3_mk_optimize(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_optimize_inc_ref(Z3_context a0, Z3_optimize a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_optimize_dec_ref(Z3_context a0, Z3_optimize a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_optimize_assert(Z3_context a0, Z3_optimize a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_optimize_assert_and_track(Z3_context a0, Z3_optimize a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_optimize_assert_soft(Z3_context a0, Z3_optimize a1, Z3_ast a2, string a3, IntPtr a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_optimize_maximize(Z3_context a0, Z3_optimize a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_optimize_minimize(Z3_context a0, Z3_optimize a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_optimize_push(Z3_context a0, Z3_optimize a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_optimize_pop(Z3_context a0, Z3_optimize a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static int Z3_optimize_check(Z3_context a0, Z3_optimize a1, uint a2, [In] Z3_ast[] a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_optimize_get_reason_unknown(Z3_context a0, Z3_optimize a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_model Z3_optimize_get_model(Z3_context a0, Z3_optimize a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_optimize_get_unsat_core(Z3_context a0, Z3_optimize a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_optimize_set_params(Z3_context a0, Z3_optimize a1, Z3_params a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_param_descrs Z3_optimize_get_param_descrs(Z3_context a0, Z3_optimize a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_optimize_get_lower(Z3_context a0, Z3_optimize a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_optimize_get_upper(Z3_context a0, Z3_optimize a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_optimize_get_lower_as_vector(Z3_context a0, Z3_optimize a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_optimize_get_upper_as_vector(Z3_context a0, Z3_optimize a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_optimize_to_string(Z3_context a0, Z3_optimize a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_optimize_from_string(Z3_context a0, Z3_optimize a1, string a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_optimize_from_file(Z3_context a0, Z3_optimize a1, string a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_optimize_get_help(Z3_context a0, Z3_optimize a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_stats Z3_optimize_get_statistics(Z3_context a0, Z3_optimize a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_optimize_get_assertions(Z3_context a0, Z3_optimize a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_optimize_get_objectives(Z3_context a0, Z3_optimize a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_fpa_rounding_mode_sort(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_round_nearest_ties_to_even(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_rne(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_round_nearest_ties_to_away(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_rna(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_round_toward_positive(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_rtp(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_round_toward_negative(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_rtn(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_round_toward_zero(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_rtz(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_fpa_sort(Z3_context a0, uint a1, uint a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_fpa_sort_half(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_fpa_sort_16(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_fpa_sort_single(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_fpa_sort_32(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_fpa_sort_double(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_fpa_sort_64(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_fpa_sort_quadruple(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_sort Z3_mk_fpa_sort_128(Z3_context a0);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_nan(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_inf(Z3_context a0, Z3_sort a1, byte a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_zero(Z3_context a0, Z3_sort a1, byte a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_fp(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_numeral_float(Z3_context a0, float a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_numeral_double(Z3_context a0, double a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_numeral_int(Z3_context a0, int a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_numeral_int_uint(Z3_context a0, byte a1, int a2, uint a3, Z3_sort a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_numeral_int64_uint64(Z3_context a0, byte a1, Int64 a2, UInt64 a3, Z3_sort a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_abs(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_neg(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_add(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_sub(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_mul(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_div(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_fma(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3, Z3_ast a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_sqrt(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_rem(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_round_to_integral(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_min(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_max(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_leq(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_lt(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_geq(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_gt(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_eq(Z3_context a0, Z3_ast a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_is_normal(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_is_subnormal(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_is_zero(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_is_infinite(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_is_nan(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_is_negative(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_is_positive(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_to_fp_bv(Z3_context a0, Z3_ast a1, Z3_sort a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_to_fp_float(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_sort a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_to_fp_real(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_sort a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_to_fp_signed(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_sort a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_to_fp_unsigned(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_sort a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_to_ubv(Z3_context a0, Z3_ast a1, Z3_ast a2, uint a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_to_sbv(Z3_context a0, Z3_ast a1, Z3_ast a2, uint a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_to_real(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_fpa_get_ebits(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static uint Z3_fpa_get_sbits(Z3_context a0, Z3_sort a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_fpa_is_numeral_nan(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_fpa_is_numeral_inf(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_fpa_is_numeral_zero(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_fpa_is_numeral_normal(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_fpa_is_numeral_subnormal(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_fpa_is_numeral_positive(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_fpa_is_numeral_negative(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_fpa_get_numeral_sign_bv(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_fpa_get_numeral_significand_bv(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_fpa_get_numeral_sign(Z3_context a0, Z3_ast a1, [In, Out] ref int a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_fpa_get_numeral_significand_string(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_fpa_get_numeral_significand_uint64(Z3_context a0, Z3_ast a1, [In, Out] ref UInt64 a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_fpa_get_numeral_exponent_string(Z3_context a0, Z3_ast a1, byte a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static byte Z3_fpa_get_numeral_exponent_int64(Z3_context a0, Z3_ast a1, [In, Out] ref Int64 a2, byte a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_fpa_get_numeral_exponent_bv(Z3_context a0, Z3_ast a1, byte a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_to_ieee_bv(Z3_context a0, Z3_ast a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_mk_fpa_to_fp_int_real(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3, Z3_sort a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static int Z3_fixedpoint_query_from_lvl(Z3_context a0, Z3_fixedpoint a1, Z3_ast a2, uint a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_fixedpoint_get_ground_sat_answer(Z3_context a0, Z3_fixedpoint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast_vector Z3_fixedpoint_get_rules_along_trace(Z3_context a0, Z3_fixedpoint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static IntPtr Z3_fixedpoint_get_rule_names_along_trace(Z3_context a0, Z3_fixedpoint a1);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static void Z3_fixedpoint_add_invariant(Z3_context a0, Z3_fixedpoint a1, Z3_func_decl a2, Z3_ast a3);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_fixedpoint_get_reachable(Z3_context a0, Z3_fixedpoint a1, Z3_func_decl a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_qe_model_project(Z3_context a0, Z3_model a1, uint a2, [In] Z3_app[] a3, Z3_ast a4);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_qe_model_project_skolem(Z3_context a0, Z3_model a1, uint a2, [In] Z3_app[] a3, Z3_ast a4, Z3_ast_map a5);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_model_extrapolate(Z3_context a0, Z3_model a1, Z3_ast a2);

            [DllImport(Z3_DLL_NAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
            public extern static Z3_ast Z3_qe_lite(Z3_context a0, Z3_ast_vector a1, Z3_ast a2);

        }

        public static void Z3_set_error_handler(Z3_context a0, Z3_error_handler a1) {
            LIB.Z3_set_error_handler(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_global_param_set(string a0, string a1) {
            LIB.Z3_global_param_set(a0, a1);
        }

        public static void Z3_global_param_reset_all() {
            LIB.Z3_global_param_reset_all();
        }

        public static byte Z3_global_param_get(string a0, out IntPtr a1) {
            byte r = LIB.Z3_global_param_get(a0, out a1);
            return r;
        }

        public static Z3_config Z3_mk_config() {
            Z3_config r = LIB.Z3_mk_config();
            return r;
        }

        public static void Z3_del_config(Z3_config a0) {
            LIB.Z3_del_config(a0);
        }

        public static void Z3_set_param_value(Z3_config a0, string a1, string a2) {
            LIB.Z3_set_param_value(a0, a1, a2);
        }

        public static Z3_context Z3_mk_context(Z3_config a0) {
            Z3_context r = LIB.Z3_mk_context(a0);
            if (r == IntPtr.Zero)
                throw new Z3Exception("Object allocation failed.");
            return r;
        }

        public static Z3_context Z3_mk_context_rc(Z3_config a0) {
            Z3_context r = LIB.Z3_mk_context_rc(a0);
            if (r == IntPtr.Zero)
                throw new Z3Exception("Object allocation failed.");
            return r;
        }

        public static void Z3_del_context(Z3_context a0) {
            LIB.Z3_del_context(a0);
        }

        public static void Z3_inc_ref(Z3_context a0, Z3_ast a1) {
            LIB.Z3_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_dec_ref(Z3_context a0, Z3_ast a1) {
            LIB.Z3_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_update_param_value(Z3_context a0, string a1, string a2) {
            LIB.Z3_update_param_value(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_interrupt(Z3_context a0) {
            LIB.Z3_interrupt(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_params Z3_mk_params(Z3_context a0) {
            Z3_params r = LIB.Z3_mk_params(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_params_inc_ref(Z3_context a0, Z3_params a1) {
            LIB.Z3_params_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_params_dec_ref(Z3_context a0, Z3_params a1) {
            LIB.Z3_params_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_params_set_bool(Z3_context a0, Z3_params a1, IntPtr a2, byte a3) {
            LIB.Z3_params_set_bool(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_params_set_uint(Z3_context a0, Z3_params a1, IntPtr a2, uint a3) {
            LIB.Z3_params_set_uint(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_params_set_double(Z3_context a0, Z3_params a1, IntPtr a2, double a3) {
            LIB.Z3_params_set_double(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_params_set_symbol(Z3_context a0, Z3_params a1, IntPtr a2, IntPtr a3) {
            LIB.Z3_params_set_symbol(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static string Z3_params_to_string(Z3_context a0, Z3_params a1) {
            IntPtr r = LIB.Z3_params_to_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static void Z3_params_validate(Z3_context a0, Z3_params a1, Z3_param_descrs a2) {
            LIB.Z3_params_validate(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_param_descrs_inc_ref(Z3_context a0, Z3_param_descrs a1) {
            LIB.Z3_param_descrs_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_param_descrs_dec_ref(Z3_context a0, Z3_param_descrs a1) {
            LIB.Z3_param_descrs_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static uint Z3_param_descrs_get_kind(Z3_context a0, Z3_param_descrs a1, IntPtr a2) {
            uint r = LIB.Z3_param_descrs_get_kind(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_param_descrs_size(Z3_context a0, Z3_param_descrs a1) {
            uint r = LIB.Z3_param_descrs_size(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static IntPtr Z3_param_descrs_get_name(Z3_context a0, Z3_param_descrs a1, uint a2) {
            IntPtr r = LIB.Z3_param_descrs_get_name(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_param_descrs_get_documentation(Z3_context a0, Z3_param_descrs a1, IntPtr a2) {
            IntPtr r = LIB.Z3_param_descrs_get_documentation(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static string Z3_param_descrs_to_string(Z3_context a0, Z3_param_descrs a1) {
            IntPtr r = LIB.Z3_param_descrs_to_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static IntPtr Z3_mk_int_symbol(Z3_context a0, int a1) {
            IntPtr r = LIB.Z3_mk_int_symbol(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static IntPtr Z3_mk_string_symbol(Z3_context a0, string a1) {
            IntPtr r = LIB.Z3_mk_string_symbol(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_uninterpreted_sort(Z3_context a0, IntPtr a1) {
            Z3_sort r = LIB.Z3_mk_uninterpreted_sort(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_bool_sort(Z3_context a0) {
            Z3_sort r = LIB.Z3_mk_bool_sort(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_int_sort(Z3_context a0) {
            Z3_sort r = LIB.Z3_mk_int_sort(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_real_sort(Z3_context a0) {
            Z3_sort r = LIB.Z3_mk_real_sort(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_bv_sort(Z3_context a0, uint a1) {
            Z3_sort r = LIB.Z3_mk_bv_sort(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_finite_domain_sort(Z3_context a0, IntPtr a1, UInt64 a2) {
            Z3_sort r = LIB.Z3_mk_finite_domain_sort(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_array_sort(Z3_context a0, Z3_sort a1, Z3_sort a2) {
            Z3_sort r = LIB.Z3_mk_array_sort(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_array_sort_n(Z3_context a0, uint a1, [In] Z3_sort[] a2, Z3_sort a3) {
            Z3_sort r = LIB.Z3_mk_array_sort_n(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_tuple_sort(Z3_context a0, IntPtr a1, uint a2, [In] IntPtr[] a3, [In] Z3_sort[] a4, [In, Out] ref Z3_func_decl a5, [Out] Z3_func_decl[] a6) {
            Z3_sort r = LIB.Z3_mk_tuple_sort(a0, a1, a2, a3, a4, ref a5, a6);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_enumeration_sort(Z3_context a0, IntPtr a1, uint a2, [In] IntPtr[] a3, [Out] Z3_func_decl[] a4, [Out] Z3_func_decl[] a5) {
            Z3_sort r = LIB.Z3_mk_enumeration_sort(a0, a1, a2, a3, a4, a5);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_list_sort(Z3_context a0, IntPtr a1, Z3_sort a2, [In, Out] ref Z3_func_decl a3, [In, Out] ref Z3_func_decl a4, [In, Out] ref Z3_func_decl a5, [In, Out] ref Z3_func_decl a6, [In, Out] ref Z3_func_decl a7, [In, Out] ref Z3_func_decl a8) {
            Z3_sort r = LIB.Z3_mk_list_sort(a0, a1, a2, ref a3, ref a4, ref a5, ref a6, ref a7, ref a8);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_constructor Z3_mk_constructor(Z3_context a0, IntPtr a1, IntPtr a2, uint a3, [In] IntPtr[] a4, [In] Z3_sort[] a5, [In] uint[] a6) {
            Z3_constructor r = LIB.Z3_mk_constructor(a0, a1, a2, a3, a4, a5, a6);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_del_constructor(Z3_context a0, Z3_constructor a1) {
            LIB.Z3_del_constructor(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_sort Z3_mk_datatype(Z3_context a0, IntPtr a1, uint a2, [In, Out] Z3_constructor[] a3) {
            Z3_sort r = LIB.Z3_mk_datatype(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_constructor_list Z3_mk_constructor_list(Z3_context a0, uint a1, [In] Z3_constructor[] a2) {
            Z3_constructor_list r = LIB.Z3_mk_constructor_list(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_del_constructor_list(Z3_context a0, Z3_constructor_list a1) {
            LIB.Z3_del_constructor_list(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_mk_datatypes(Z3_context a0, uint a1, [In] IntPtr[] a2, [Out] Z3_sort[] a3, [In, Out] Z3_constructor_list[] a4) {
            LIB.Z3_mk_datatypes(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_query_constructor(Z3_context a0, Z3_constructor a1, uint a2, [In, Out] ref Z3_func_decl a3, [In, Out] ref Z3_func_decl a4, [Out] Z3_func_decl[] a5) {
            LIB.Z3_query_constructor(a0, a1, a2, ref a3, ref a4, a5);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_func_decl Z3_mk_func_decl(Z3_context a0, IntPtr a1, uint a2, [In] Z3_sort[] a3, Z3_sort a4) {
            Z3_func_decl r = LIB.Z3_mk_func_decl(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_app(Z3_context a0, Z3_func_decl a1, uint a2, [In] Z3_ast[] a3) {
            Z3_ast r = LIB.Z3_mk_app(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_const(Z3_context a0, IntPtr a1, Z3_sort a2) {
            Z3_ast r = LIB.Z3_mk_const(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_mk_fresh_func_decl(Z3_context a0, string a1, uint a2, [In] Z3_sort[] a3, Z3_sort a4) {
            Z3_func_decl r = LIB.Z3_mk_fresh_func_decl(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fresh_const(Z3_context a0, string a1, Z3_sort a2) {
            Z3_ast r = LIB.Z3_mk_fresh_const(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_mk_rec_func_decl(Z3_context a0, IntPtr a1, uint a2, [In] Z3_sort[] a3, Z3_sort a4) {
            Z3_func_decl r = LIB.Z3_mk_rec_func_decl(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_add_rec_def(Z3_context a0, Z3_func_decl a1, uint a2, [In] Z3_ast[] a3, Z3_ast a4) {
            LIB.Z3_add_rec_def(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_ast Z3_mk_true(Z3_context a0) {
            Z3_ast r = LIB.Z3_mk_true(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_false(Z3_context a0) {
            Z3_ast r = LIB.Z3_mk_false(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_eq(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_eq(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_distinct(Z3_context a0, uint a1, [In] Z3_ast[] a2) {
            Z3_ast r = LIB.Z3_mk_distinct(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_not(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_not(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_ite(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3) {
            Z3_ast r = LIB.Z3_mk_ite(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_iff(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_iff(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_implies(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_implies(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_xor(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_xor(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_and(Z3_context a0, uint a1, [In] Z3_ast[] a2) {
            Z3_ast r = LIB.Z3_mk_and(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_or(Z3_context a0, uint a1, [In] Z3_ast[] a2) {
            Z3_ast r = LIB.Z3_mk_or(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_add(Z3_context a0, uint a1, [In] Z3_ast[] a2) {
            Z3_ast r = LIB.Z3_mk_add(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_mul(Z3_context a0, uint a1, [In] Z3_ast[] a2) {
            Z3_ast r = LIB.Z3_mk_mul(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_sub(Z3_context a0, uint a1, [In] Z3_ast[] a2) {
            Z3_ast r = LIB.Z3_mk_sub(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_unary_minus(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_unary_minus(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_div(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_div(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_mod(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_mod(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_rem(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_rem(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_power(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_power(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_lt(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_lt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_le(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_le(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_gt(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_gt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_ge(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_ge(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_divides(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_divides(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_int2real(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_int2real(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_real2int(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_real2int(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_is_int(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_is_int(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvnot(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_bvnot(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvredand(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_bvredand(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvredor(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_bvredor(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvand(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvand(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvor(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvor(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvxor(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvxor(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvnand(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvnand(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvnor(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvnor(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvxnor(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvxnor(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvneg(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_bvneg(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvadd(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvadd(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvsub(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvsub(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvmul(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvmul(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvudiv(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvudiv(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvsdiv(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvsdiv(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvurem(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvurem(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvsrem(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvsrem(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvsmod(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvsmod(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvult(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvult(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvslt(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvslt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvule(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvule(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvsle(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvsle(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvuge(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvuge(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvsge(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvsge(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvugt(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvugt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvsgt(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvsgt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_concat(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_concat(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_extract(Z3_context a0, uint a1, uint a2, Z3_ast a3) {
            Z3_ast r = LIB.Z3_mk_extract(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_sign_ext(Z3_context a0, uint a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_sign_ext(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_zero_ext(Z3_context a0, uint a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_zero_ext(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_repeat(Z3_context a0, uint a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_repeat(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvshl(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvshl(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvlshr(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvlshr(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvashr(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvashr(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_rotate_left(Z3_context a0, uint a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_rotate_left(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_rotate_right(Z3_context a0, uint a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_rotate_right(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_ext_rotate_left(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_ext_rotate_left(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_ext_rotate_right(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_ext_rotate_right(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_int2bv(Z3_context a0, uint a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_int2bv(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bv2int(Z3_context a0, Z3_ast a1, byte a2) {
            Z3_ast r = LIB.Z3_mk_bv2int(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvadd_no_overflow(Z3_context a0, Z3_ast a1, Z3_ast a2, byte a3) {
            Z3_ast r = LIB.Z3_mk_bvadd_no_overflow(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvadd_no_underflow(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvadd_no_underflow(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvsub_no_overflow(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvsub_no_overflow(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvsub_no_underflow(Z3_context a0, Z3_ast a1, Z3_ast a2, byte a3) {
            Z3_ast r = LIB.Z3_mk_bvsub_no_underflow(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvsdiv_no_overflow(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvsdiv_no_overflow(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvneg_no_overflow(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_bvneg_no_overflow(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvmul_no_overflow(Z3_context a0, Z3_ast a1, Z3_ast a2, byte a3) {
            Z3_ast r = LIB.Z3_mk_bvmul_no_overflow(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bvmul_no_underflow(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_bvmul_no_underflow(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_select(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_select(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_select_n(Z3_context a0, Z3_ast a1, uint a2, [In] Z3_ast[] a3) {
            Z3_ast r = LIB.Z3_mk_select_n(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_store(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3) {
            Z3_ast r = LIB.Z3_mk_store(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_store_n(Z3_context a0, Z3_ast a1, uint a2, [In] Z3_ast[] a3, Z3_ast a4) {
            Z3_ast r = LIB.Z3_mk_store_n(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_const_array(Z3_context a0, Z3_sort a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_const_array(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_map(Z3_context a0, Z3_func_decl a1, uint a2, [In] Z3_ast[] a3) {
            Z3_ast r = LIB.Z3_mk_map(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_array_default(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_array_default(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_as_array(Z3_context a0, Z3_func_decl a1) {
            Z3_ast r = LIB.Z3_mk_as_array(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_set_has_size(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_set_has_size(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_set_sort(Z3_context a0, Z3_sort a1) {
            Z3_sort r = LIB.Z3_mk_set_sort(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_empty_set(Z3_context a0, Z3_sort a1) {
            Z3_ast r = LIB.Z3_mk_empty_set(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_full_set(Z3_context a0, Z3_sort a1) {
            Z3_ast r = LIB.Z3_mk_full_set(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_set_add(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_set_add(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_set_del(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_set_del(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_set_union(Z3_context a0, uint a1, [In] Z3_ast[] a2) {
            Z3_ast r = LIB.Z3_mk_set_union(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_set_intersect(Z3_context a0, uint a1, [In] Z3_ast[] a2) {
            Z3_ast r = LIB.Z3_mk_set_intersect(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_set_difference(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_set_difference(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_set_complement(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_set_complement(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_set_member(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_set_member(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_set_subset(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_set_subset(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_array_ext(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_array_ext(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_numeral(Z3_context a0, string a1, Z3_sort a2) {
            Z3_ast r = LIB.Z3_mk_numeral(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_real(Z3_context a0, int a1, int a2) {
            Z3_ast r = LIB.Z3_mk_real(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_int(Z3_context a0, int a1, Z3_sort a2) {
            Z3_ast r = LIB.Z3_mk_int(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_unsigned_int(Z3_context a0, uint a1, Z3_sort a2) {
            Z3_ast r = LIB.Z3_mk_unsigned_int(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_int64(Z3_context a0, Int64 a1, Z3_sort a2) {
            Z3_ast r = LIB.Z3_mk_int64(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_unsigned_int64(Z3_context a0, UInt64 a1, Z3_sort a2) {
            Z3_ast r = LIB.Z3_mk_unsigned_int64(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bv_numeral(Z3_context a0, uint a1, [In] byte[] a2) {
            Z3_ast r = LIB.Z3_mk_bv_numeral(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_seq_sort(Z3_context a0, Z3_sort a1) {
            Z3_sort r = LIB.Z3_mk_seq_sort(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_seq_sort(Z3_context a0, Z3_sort a1) {
            byte r = LIB.Z3_is_seq_sort(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_get_seq_sort_basis(Z3_context a0, Z3_sort a1) {
            Z3_sort r = LIB.Z3_get_seq_sort_basis(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_re_sort(Z3_context a0, Z3_sort a1) {
            Z3_sort r = LIB.Z3_mk_re_sort(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_re_sort(Z3_context a0, Z3_sort a1) {
            byte r = LIB.Z3_is_re_sort(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_get_re_sort_basis(Z3_context a0, Z3_sort a1) {
            Z3_sort r = LIB.Z3_get_re_sort_basis(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_string_sort(Z3_context a0) {
            Z3_sort r = LIB.Z3_mk_string_sort(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_string_sort(Z3_context a0, Z3_sort a1) {
            byte r = LIB.Z3_is_string_sort(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_string(Z3_context a0, string a1) {
            Z3_ast r = LIB.Z3_mk_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_lstring(Z3_context a0, uint a1, string a2) {
            Z3_ast r = LIB.Z3_mk_lstring(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_string(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_is_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_get_string(Z3_context a0, Z3_ast a1) {
            IntPtr r = LIB.Z3_get_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static IntPtr Z3_get_lstring(Z3_context a0, Z3_ast a1, [In, Out] ref uint a2) {
            IntPtr r = LIB.Z3_get_lstring(a0, a1, ref a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_empty(Z3_context a0, Z3_sort a1) {
            Z3_ast r = LIB.Z3_mk_seq_empty(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_unit(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_seq_unit(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_concat(Z3_context a0, uint a1, [In] Z3_ast[] a2) {
            Z3_ast r = LIB.Z3_mk_seq_concat(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_prefix(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_seq_prefix(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_suffix(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_seq_suffix(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_contains(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_seq_contains(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_str_lt(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_str_lt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_str_le(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_str_le(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_extract(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3) {
            Z3_ast r = LIB.Z3_mk_seq_extract(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_replace(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3) {
            Z3_ast r = LIB.Z3_mk_seq_replace(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_at(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_seq_at(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_nth(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_seq_nth(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_length(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_seq_length(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_index(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3) {
            Z3_ast r = LIB.Z3_mk_seq_index(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_last_index(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_seq_last_index(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_str_to_int(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_str_to_int(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_int_to_str(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_int_to_str(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_to_re(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_seq_to_re(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_seq_in_re(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_seq_in_re(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_re_plus(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_re_plus(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_re_star(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_re_star(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_re_option(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_re_option(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_re_union(Z3_context a0, uint a1, [In] Z3_ast[] a2) {
            Z3_ast r = LIB.Z3_mk_re_union(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_re_concat(Z3_context a0, uint a1, [In] Z3_ast[] a2) {
            Z3_ast r = LIB.Z3_mk_re_concat(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_re_range(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_re_range(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_re_loop(Z3_context a0, Z3_ast a1, uint a2, uint a3) {
            Z3_ast r = LIB.Z3_mk_re_loop(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_re_intersect(Z3_context a0, uint a1, [In] Z3_ast[] a2) {
            Z3_ast r = LIB.Z3_mk_re_intersect(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_re_complement(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_re_complement(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_re_empty(Z3_context a0, Z3_sort a1) {
            Z3_ast r = LIB.Z3_mk_re_empty(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_re_full(Z3_context a0, Z3_sort a1) {
            Z3_ast r = LIB.Z3_mk_re_full(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_mk_linear_order(Z3_context a0, Z3_sort a1, uint a2) {
            Z3_func_decl r = LIB.Z3_mk_linear_order(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_mk_partial_order(Z3_context a0, Z3_sort a1, uint a2) {
            Z3_func_decl r = LIB.Z3_mk_partial_order(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_mk_piecewise_linear_order(Z3_context a0, Z3_sort a1, uint a2) {
            Z3_func_decl r = LIB.Z3_mk_piecewise_linear_order(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_mk_tree_order(Z3_context a0, Z3_sort a1, uint a2) {
            Z3_func_decl r = LIB.Z3_mk_tree_order(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_mk_transitive_closure(Z3_context a0, Z3_func_decl a1) {
            Z3_func_decl r = LIB.Z3_mk_transitive_closure(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_pattern Z3_mk_pattern(Z3_context a0, uint a1, [In] Z3_ast[] a2) {
            Z3_pattern r = LIB.Z3_mk_pattern(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_bound(Z3_context a0, uint a1, Z3_sort a2) {
            Z3_ast r = LIB.Z3_mk_bound(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_forall(Z3_context a0, uint a1, uint a2, [In] Z3_pattern[] a3, uint a4, [In] Z3_sort[] a5, [In] IntPtr[] a6, Z3_ast a7) {
            Z3_ast r = LIB.Z3_mk_forall(a0, a1, a2, a3, a4, a5, a6, a7);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_exists(Z3_context a0, uint a1, uint a2, [In] Z3_pattern[] a3, uint a4, [In] Z3_sort[] a5, [In] IntPtr[] a6, Z3_ast a7) {
            Z3_ast r = LIB.Z3_mk_exists(a0, a1, a2, a3, a4, a5, a6, a7);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_quantifier(Z3_context a0, byte a1, uint a2, uint a3, [In] Z3_pattern[] a4, uint a5, [In] Z3_sort[] a6, [In] IntPtr[] a7, Z3_ast a8) {
            Z3_ast r = LIB.Z3_mk_quantifier(a0, a1, a2, a3, a4, a5, a6, a7, a8);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_quantifier_ex(Z3_context a0, byte a1, uint a2, IntPtr a3, IntPtr a4, uint a5, [In] Z3_pattern[] a6, uint a7, [In] Z3_ast[] a8, uint a9, [In] Z3_sort[] a10, [In] IntPtr[] a11, Z3_ast a12) {
            Z3_ast r = LIB.Z3_mk_quantifier_ex(a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_forall_const(Z3_context a0, uint a1, uint a2, [In] Z3_app[] a3, uint a4, [In] Z3_pattern[] a5, Z3_ast a6) {
            Z3_ast r = LIB.Z3_mk_forall_const(a0, a1, a2, a3, a4, a5, a6);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_exists_const(Z3_context a0, uint a1, uint a2, [In] Z3_app[] a3, uint a4, [In] Z3_pattern[] a5, Z3_ast a6) {
            Z3_ast r = LIB.Z3_mk_exists_const(a0, a1, a2, a3, a4, a5, a6);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_quantifier_const(Z3_context a0, byte a1, uint a2, uint a3, [In] Z3_app[] a4, uint a5, [In] Z3_pattern[] a6, Z3_ast a7) {
            Z3_ast r = LIB.Z3_mk_quantifier_const(a0, a1, a2, a3, a4, a5, a6, a7);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_quantifier_const_ex(Z3_context a0, byte a1, uint a2, IntPtr a3, IntPtr a4, uint a5, [In] Z3_app[] a6, uint a7, [In] Z3_pattern[] a8, uint a9, [In] Z3_ast[] a10, Z3_ast a11) {
            Z3_ast r = LIB.Z3_mk_quantifier_const_ex(a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_lambda(Z3_context a0, uint a1, [In] Z3_sort[] a2, [In] IntPtr[] a3, Z3_ast a4) {
            Z3_ast r = LIB.Z3_mk_lambda(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_lambda_const(Z3_context a0, uint a1, [In] Z3_app[] a2, Z3_ast a3) {
            Z3_ast r = LIB.Z3_mk_lambda_const(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_symbol_kind(Z3_context a0, IntPtr a1) {
            uint r = LIB.Z3_get_symbol_kind(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static int Z3_get_symbol_int(Z3_context a0, IntPtr a1) {
            int r = LIB.Z3_get_symbol_int(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_get_symbol_string(Z3_context a0, IntPtr a1) {
            IntPtr r = LIB.Z3_get_symbol_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static IntPtr Z3_get_sort_name(Z3_context a0, Z3_sort a1) {
            IntPtr r = LIB.Z3_get_sort_name(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_sort_id(Z3_context a0, Z3_sort a1) {
            uint r = LIB.Z3_get_sort_id(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_sort_to_ast(Z3_context a0, Z3_sort a1) {
            Z3_ast r = LIB.Z3_sort_to_ast(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_eq_sort(Z3_context a0, Z3_sort a1, Z3_sort a2) {
            byte r = LIB.Z3_is_eq_sort(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_sort_kind(Z3_context a0, Z3_sort a1) {
            uint r = LIB.Z3_get_sort_kind(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_bv_sort_size(Z3_context a0, Z3_sort a1) {
            uint r = LIB.Z3_get_bv_sort_size(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_get_finite_domain_sort_size(Z3_context a0, Z3_sort a1, [In, Out] ref UInt64 a2) {
            byte r = LIB.Z3_get_finite_domain_sort_size(a0, a1, ref a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_get_array_sort_domain(Z3_context a0, Z3_sort a1) {
            Z3_sort r = LIB.Z3_get_array_sort_domain(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_get_array_sort_range(Z3_context a0, Z3_sort a1) {
            Z3_sort r = LIB.Z3_get_array_sort_range(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_get_tuple_sort_mk_decl(Z3_context a0, Z3_sort a1) {
            Z3_func_decl r = LIB.Z3_get_tuple_sort_mk_decl(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_tuple_sort_num_fields(Z3_context a0, Z3_sort a1) {
            uint r = LIB.Z3_get_tuple_sort_num_fields(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_get_tuple_sort_field_decl(Z3_context a0, Z3_sort a1, uint a2) {
            Z3_func_decl r = LIB.Z3_get_tuple_sort_field_decl(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_datatype_sort_num_constructors(Z3_context a0, Z3_sort a1) {
            uint r = LIB.Z3_get_datatype_sort_num_constructors(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_get_datatype_sort_constructor(Z3_context a0, Z3_sort a1, uint a2) {
            Z3_func_decl r = LIB.Z3_get_datatype_sort_constructor(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_get_datatype_sort_recognizer(Z3_context a0, Z3_sort a1, uint a2) {
            Z3_func_decl r = LIB.Z3_get_datatype_sort_recognizer(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_get_datatype_sort_constructor_accessor(Z3_context a0, Z3_sort a1, uint a2, uint a3) {
            Z3_func_decl r = LIB.Z3_get_datatype_sort_constructor_accessor(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_datatype_update_field(Z3_context a0, Z3_func_decl a1, Z3_ast a2, Z3_ast a3) {
            Z3_ast r = LIB.Z3_datatype_update_field(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_relation_arity(Z3_context a0, Z3_sort a1) {
            uint r = LIB.Z3_get_relation_arity(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_get_relation_column(Z3_context a0, Z3_sort a1, uint a2) {
            Z3_sort r = LIB.Z3_get_relation_column(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_atmost(Z3_context a0, uint a1, [In] Z3_ast[] a2, uint a3) {
            Z3_ast r = LIB.Z3_mk_atmost(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_atleast(Z3_context a0, uint a1, [In] Z3_ast[] a2, uint a3) {
            Z3_ast r = LIB.Z3_mk_atleast(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_pble(Z3_context a0, uint a1, [In] Z3_ast[] a2, [In] int[] a3, int a4) {
            Z3_ast r = LIB.Z3_mk_pble(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_pbge(Z3_context a0, uint a1, [In] Z3_ast[] a2, [In] int[] a3, int a4) {
            Z3_ast r = LIB.Z3_mk_pbge(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_pbeq(Z3_context a0, uint a1, [In] Z3_ast[] a2, [In] int[] a3, int a4) {
            Z3_ast r = LIB.Z3_mk_pbeq(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_func_decl_to_ast(Z3_context a0, Z3_func_decl a1) {
            Z3_ast r = LIB.Z3_func_decl_to_ast(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_eq_func_decl(Z3_context a0, Z3_func_decl a1, Z3_func_decl a2) {
            byte r = LIB.Z3_is_eq_func_decl(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_func_decl_id(Z3_context a0, Z3_func_decl a1) {
            uint r = LIB.Z3_get_func_decl_id(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static IntPtr Z3_get_decl_name(Z3_context a0, Z3_func_decl a1) {
            IntPtr r = LIB.Z3_get_decl_name(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_decl_kind(Z3_context a0, Z3_func_decl a1) {
            uint r = LIB.Z3_get_decl_kind(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_domain_size(Z3_context a0, Z3_func_decl a1) {
            uint r = LIB.Z3_get_domain_size(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_arity(Z3_context a0, Z3_func_decl a1) {
            uint r = LIB.Z3_get_arity(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_get_domain(Z3_context a0, Z3_func_decl a1, uint a2) {
            Z3_sort r = LIB.Z3_get_domain(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_get_range(Z3_context a0, Z3_func_decl a1) {
            Z3_sort r = LIB.Z3_get_range(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_decl_num_parameters(Z3_context a0, Z3_func_decl a1) {
            uint r = LIB.Z3_get_decl_num_parameters(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_decl_parameter_kind(Z3_context a0, Z3_func_decl a1, uint a2) {
            uint r = LIB.Z3_get_decl_parameter_kind(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static int Z3_get_decl_int_parameter(Z3_context a0, Z3_func_decl a1, uint a2) {
            int r = LIB.Z3_get_decl_int_parameter(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static double Z3_get_decl_double_parameter(Z3_context a0, Z3_func_decl a1, uint a2) {
            double r = LIB.Z3_get_decl_double_parameter(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static IntPtr Z3_get_decl_symbol_parameter(Z3_context a0, Z3_func_decl a1, uint a2) {
            IntPtr r = LIB.Z3_get_decl_symbol_parameter(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_get_decl_sort_parameter(Z3_context a0, Z3_func_decl a1, uint a2) {
            Z3_sort r = LIB.Z3_get_decl_sort_parameter(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_get_decl_ast_parameter(Z3_context a0, Z3_func_decl a1, uint a2) {
            Z3_ast r = LIB.Z3_get_decl_ast_parameter(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_get_decl_func_decl_parameter(Z3_context a0, Z3_func_decl a1, uint a2) {
            Z3_func_decl r = LIB.Z3_get_decl_func_decl_parameter(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_get_decl_rational_parameter(Z3_context a0, Z3_func_decl a1, uint a2) {
            IntPtr r = LIB.Z3_get_decl_rational_parameter(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static Z3_ast Z3_app_to_ast(Z3_context a0, Z3_app a1) {
            Z3_ast r = LIB.Z3_app_to_ast(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_get_app_decl(Z3_context a0, Z3_app a1) {
            Z3_func_decl r = LIB.Z3_get_app_decl(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_app_num_args(Z3_context a0, Z3_app a1) {
            uint r = LIB.Z3_get_app_num_args(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_get_app_arg(Z3_context a0, Z3_app a1, uint a2) {
            Z3_ast r = LIB.Z3_get_app_arg(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_eq_ast(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            byte r = LIB.Z3_is_eq_ast(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_ast_id(Z3_context a0, Z3_ast a1) {
            uint r = LIB.Z3_get_ast_id(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_ast_hash(Z3_context a0, Z3_ast a1) {
            uint r = LIB.Z3_get_ast_hash(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_get_sort(Z3_context a0, Z3_ast a1) {
            Z3_sort r = LIB.Z3_get_sort(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_well_sorted(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_is_well_sorted(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static int Z3_get_bool_value(Z3_context a0, Z3_ast a1) {
            int r = LIB.Z3_get_bool_value(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_ast_kind(Z3_context a0, Z3_ast a1) {
            uint r = LIB.Z3_get_ast_kind(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_app(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_is_app(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_numeral_ast(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_is_numeral_ast(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_algebraic_number(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_is_algebraic_number(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_app Z3_to_app(Z3_context a0, Z3_ast a1) {
            Z3_app r = LIB.Z3_to_app(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_to_func_decl(Z3_context a0, Z3_ast a1) {
            Z3_func_decl r = LIB.Z3_to_func_decl(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_get_numeral_string(Z3_context a0, Z3_ast a1) {
            IntPtr r = LIB.Z3_get_numeral_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static string Z3_get_numeral_decimal_string(Z3_context a0, Z3_ast a1, uint a2) {
            IntPtr r = LIB.Z3_get_numeral_decimal_string(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static double Z3_get_numeral_double(Z3_context a0, Z3_ast a1) {
            double r = LIB.Z3_get_numeral_double(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_get_numerator(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_get_numerator(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_get_denominator(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_get_denominator(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_get_numeral_small(Z3_context a0, Z3_ast a1, [In, Out] ref Int64 a2, [In, Out] ref Int64 a3) {
            byte r = LIB.Z3_get_numeral_small(a0, a1, ref a2, ref a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_get_numeral_int(Z3_context a0, Z3_ast a1, [In, Out] ref int a2) {
            byte r = LIB.Z3_get_numeral_int(a0, a1, ref a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_get_numeral_uint(Z3_context a0, Z3_ast a1, [In, Out] ref uint a2) {
            byte r = LIB.Z3_get_numeral_uint(a0, a1, ref a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_get_numeral_uint64(Z3_context a0, Z3_ast a1, [In, Out] ref UInt64 a2) {
            byte r = LIB.Z3_get_numeral_uint64(a0, a1, ref a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_get_numeral_int64(Z3_context a0, Z3_ast a1, [In, Out] ref Int64 a2) {
            byte r = LIB.Z3_get_numeral_int64(a0, a1, ref a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_get_numeral_rational_int64(Z3_context a0, Z3_ast a1, [In, Out] ref Int64 a2, [In, Out] ref Int64 a3) {
            byte r = LIB.Z3_get_numeral_rational_int64(a0, a1, ref a2, ref a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_get_algebraic_number_lower(Z3_context a0, Z3_ast a1, uint a2) {
            Z3_ast r = LIB.Z3_get_algebraic_number_lower(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_get_algebraic_number_upper(Z3_context a0, Z3_ast a1, uint a2) {
            Z3_ast r = LIB.Z3_get_algebraic_number_upper(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_pattern_to_ast(Z3_context a0, Z3_pattern a1) {
            Z3_ast r = LIB.Z3_pattern_to_ast(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_pattern_num_terms(Z3_context a0, Z3_pattern a1) {
            uint r = LIB.Z3_get_pattern_num_terms(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_get_pattern(Z3_context a0, Z3_pattern a1, uint a2) {
            Z3_ast r = LIB.Z3_get_pattern(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_index_value(Z3_context a0, Z3_ast a1) {
            uint r = LIB.Z3_get_index_value(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_quantifier_forall(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_is_quantifier_forall(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_quantifier_exists(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_is_quantifier_exists(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_lambda(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_is_lambda(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_quantifier_weight(Z3_context a0, Z3_ast a1) {
            uint r = LIB.Z3_get_quantifier_weight(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_quantifier_num_patterns(Z3_context a0, Z3_ast a1) {
            uint r = LIB.Z3_get_quantifier_num_patterns(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_pattern Z3_get_quantifier_pattern_ast(Z3_context a0, Z3_ast a1, uint a2) {
            Z3_pattern r = LIB.Z3_get_quantifier_pattern_ast(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_quantifier_num_no_patterns(Z3_context a0, Z3_ast a1) {
            uint r = LIB.Z3_get_quantifier_num_no_patterns(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_get_quantifier_no_pattern_ast(Z3_context a0, Z3_ast a1, uint a2) {
            Z3_ast r = LIB.Z3_get_quantifier_no_pattern_ast(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_quantifier_num_bound(Z3_context a0, Z3_ast a1) {
            uint r = LIB.Z3_get_quantifier_num_bound(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static IntPtr Z3_get_quantifier_bound_name(Z3_context a0, Z3_ast a1, uint a2) {
            IntPtr r = LIB.Z3_get_quantifier_bound_name(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_get_quantifier_bound_sort(Z3_context a0, Z3_ast a1, uint a2) {
            Z3_sort r = LIB.Z3_get_quantifier_bound_sort(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_get_quantifier_body(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_get_quantifier_body(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_simplify(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_simplify(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_simplify_ex(Z3_context a0, Z3_ast a1, Z3_params a2) {
            Z3_ast r = LIB.Z3_simplify_ex(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_simplify_get_help(Z3_context a0) {
            IntPtr r = LIB.Z3_simplify_get_help(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static Z3_param_descrs Z3_simplify_get_param_descrs(Z3_context a0) {
            Z3_param_descrs r = LIB.Z3_simplify_get_param_descrs(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_update_term(Z3_context a0, Z3_ast a1, uint a2, [In] Z3_ast[] a3) {
            Z3_ast r = LIB.Z3_update_term(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_substitute(Z3_context a0, Z3_ast a1, uint a2, [In] Z3_ast[] a3, [In] Z3_ast[] a4) {
            Z3_ast r = LIB.Z3_substitute(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_substitute_vars(Z3_context a0, Z3_ast a1, uint a2, [In] Z3_ast[] a3) {
            Z3_ast r = LIB.Z3_substitute_vars(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_translate(Z3_context a0, Z3_ast a1, Z3_context a2) {
            Z3_ast r = LIB.Z3_translate(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_model Z3_mk_model(Z3_context a0) {
            Z3_model r = LIB.Z3_mk_model(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_model_inc_ref(Z3_context a0, Z3_model a1) {
            LIB.Z3_model_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_model_dec_ref(Z3_context a0, Z3_model a1) {
            LIB.Z3_model_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static byte Z3_model_eval(Z3_context a0, Z3_model a1, Z3_ast a2, byte a3, [In, Out] ref Z3_ast a4) {
            byte r = LIB.Z3_model_eval(a0, a1, a2, a3, ref a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_model_get_const_interp(Z3_context a0, Z3_model a1, Z3_func_decl a2) {
            Z3_ast r = LIB.Z3_model_get_const_interp(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_model_has_interp(Z3_context a0, Z3_model a1, Z3_func_decl a2) {
            byte r = LIB.Z3_model_has_interp(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_interp Z3_model_get_func_interp(Z3_context a0, Z3_model a1, Z3_func_decl a2) {
            Z3_func_interp r = LIB.Z3_model_get_func_interp(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_model_get_num_consts(Z3_context a0, Z3_model a1) {
            uint r = LIB.Z3_model_get_num_consts(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_model_get_const_decl(Z3_context a0, Z3_model a1, uint a2) {
            Z3_func_decl r = LIB.Z3_model_get_const_decl(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_model_get_num_funcs(Z3_context a0, Z3_model a1) {
            uint r = LIB.Z3_model_get_num_funcs(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_model_get_func_decl(Z3_context a0, Z3_model a1, uint a2) {
            Z3_func_decl r = LIB.Z3_model_get_func_decl(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_model_get_num_sorts(Z3_context a0, Z3_model a1) {
            uint r = LIB.Z3_model_get_num_sorts(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_model_get_sort(Z3_context a0, Z3_model a1, uint a2) {
            Z3_sort r = LIB.Z3_model_get_sort(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_model_get_sort_universe(Z3_context a0, Z3_model a1, Z3_sort a2) {
            Z3_ast_vector r = LIB.Z3_model_get_sort_universe(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_model Z3_model_translate(Z3_context a0, Z3_model a1, Z3_context a2) {
            Z3_model r = LIB.Z3_model_translate(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_is_as_array(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_is_as_array(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_decl Z3_get_as_array_func_decl(Z3_context a0, Z3_ast a1) {
            Z3_func_decl r = LIB.Z3_get_as_array_func_decl(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_interp Z3_add_func_interp(Z3_context a0, Z3_model a1, Z3_func_decl a2, Z3_ast a3) {
            Z3_func_interp r = LIB.Z3_add_func_interp(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_add_const_interp(Z3_context a0, Z3_model a1, Z3_func_decl a2, Z3_ast a3) {
            LIB.Z3_add_const_interp(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_func_interp_inc_ref(Z3_context a0, Z3_func_interp a1) {
            LIB.Z3_func_interp_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_func_interp_dec_ref(Z3_context a0, Z3_func_interp a1) {
            LIB.Z3_func_interp_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static uint Z3_func_interp_get_num_entries(Z3_context a0, Z3_func_interp a1) {
            uint r = LIB.Z3_func_interp_get_num_entries(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_func_entry Z3_func_interp_get_entry(Z3_context a0, Z3_func_interp a1, uint a2) {
            Z3_func_entry r = LIB.Z3_func_interp_get_entry(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_func_interp_get_else(Z3_context a0, Z3_func_interp a1) {
            Z3_ast r = LIB.Z3_func_interp_get_else(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_func_interp_set_else(Z3_context a0, Z3_func_interp a1, Z3_ast a2) {
            LIB.Z3_func_interp_set_else(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static uint Z3_func_interp_get_arity(Z3_context a0, Z3_func_interp a1) {
            uint r = LIB.Z3_func_interp_get_arity(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_func_interp_add_entry(Z3_context a0, Z3_func_interp a1, Z3_ast_vector a2, Z3_ast a3) {
            LIB.Z3_func_interp_add_entry(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_func_entry_inc_ref(Z3_context a0, Z3_func_entry a1) {
            LIB.Z3_func_entry_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_func_entry_dec_ref(Z3_context a0, Z3_func_entry a1) {
            LIB.Z3_func_entry_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_ast Z3_func_entry_get_value(Z3_context a0, Z3_func_entry a1) {
            Z3_ast r = LIB.Z3_func_entry_get_value(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_func_entry_get_num_args(Z3_context a0, Z3_func_entry a1) {
            uint r = LIB.Z3_func_entry_get_num_args(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_func_entry_get_arg(Z3_context a0, Z3_func_entry a1, uint a2) {
            Z3_ast r = LIB.Z3_func_entry_get_arg(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static int Z3_open_log(string a0) {
            int r = LIB.Z3_open_log(a0);
            return r;
        }

        public static void Z3_append_log(string a0) {
            LIB.Z3_append_log(a0);
        }

        public static void Z3_close_log() {
            LIB.Z3_close_log();
        }

        public static void Z3_toggle_warning_messages(byte a0) {
            LIB.Z3_toggle_warning_messages(a0);
        }

        public static void Z3_set_ast_print_mode(Z3_context a0, uint a1) {
            LIB.Z3_set_ast_print_mode(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static string Z3_ast_to_string(Z3_context a0, Z3_ast a1) {
            IntPtr r = LIB.Z3_ast_to_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static string Z3_pattern_to_string(Z3_context a0, Z3_pattern a1) {
            IntPtr r = LIB.Z3_pattern_to_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static string Z3_sort_to_string(Z3_context a0, Z3_sort a1) {
            IntPtr r = LIB.Z3_sort_to_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static string Z3_func_decl_to_string(Z3_context a0, Z3_func_decl a1) {
            IntPtr r = LIB.Z3_func_decl_to_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static string Z3_model_to_string(Z3_context a0, Z3_model a1) {
            IntPtr r = LIB.Z3_model_to_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static string Z3_benchmark_to_smtlib_string(Z3_context a0, string a1, string a2, string a3, string a4, uint a5, [In] Z3_ast[] a6, Z3_ast a7) {
            IntPtr r = LIB.Z3_benchmark_to_smtlib_string(a0, a1, a2, a3, a4, a5, a6, a7);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static Z3_ast_vector Z3_parse_smtlib2_string(Z3_context a0, string a1, uint a2, [In] IntPtr[] a3, [In] Z3_sort[] a4, uint a5, [In] IntPtr[] a6, [In] Z3_func_decl[] a7) {
            Z3_ast_vector r = LIB.Z3_parse_smtlib2_string(a0, a1, a2, a3, a4, a5, a6, a7);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_parse_smtlib2_file(Z3_context a0, string a1, uint a2, [In] IntPtr[] a3, [In] Z3_sort[] a4, uint a5, [In] IntPtr[] a6, [In] Z3_func_decl[] a7) {
            Z3_ast_vector r = LIB.Z3_parse_smtlib2_file(a0, a1, a2, a3, a4, a5, a6, a7);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_eval_smtlib2_string(Z3_context a0, string a1) {
            IntPtr r = LIB.Z3_eval_smtlib2_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static uint Z3_get_error_code(Z3_context a0) {
            uint r = LIB.Z3_get_error_code(a0);
            return r;
        }

        public static void Z3_set_error(Z3_context a0, uint a1) {
            LIB.Z3_set_error(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static string Z3_get_error_msg(Z3_context a0, uint a1) {
            IntPtr r = LIB.Z3_get_error_msg(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static void Z3_get_version([In, Out] ref uint a0, [In, Out] ref uint a1, [In, Out] ref uint a2, [In, Out] ref uint a3) {
            LIB.Z3_get_version(ref a0, ref a1, ref a2, ref a3);
        }

        public static string Z3_get_full_version() {
            IntPtr r = LIB.Z3_get_full_version();
            return Marshal.PtrToStringAnsi(r);
        }

        public static void Z3_enable_trace(string a0) {
            LIB.Z3_enable_trace(a0);
        }

        public static void Z3_disable_trace(string a0) {
            LIB.Z3_disable_trace(a0);
        }

        public static void Z3_reset_memory() {
            LIB.Z3_reset_memory();
        }

        public static void Z3_finalize_memory() {
            LIB.Z3_finalize_memory();
        }

        public static Z3_goal Z3_mk_goal(Z3_context a0, byte a1, byte a2, byte a3) {
            Z3_goal r = LIB.Z3_mk_goal(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_goal_inc_ref(Z3_context a0, Z3_goal a1) {
            LIB.Z3_goal_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_goal_dec_ref(Z3_context a0, Z3_goal a1) {
            LIB.Z3_goal_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static uint Z3_goal_precision(Z3_context a0, Z3_goal a1) {
            uint r = LIB.Z3_goal_precision(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_goal_assert(Z3_context a0, Z3_goal a1, Z3_ast a2) {
            LIB.Z3_goal_assert(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static byte Z3_goal_inconsistent(Z3_context a0, Z3_goal a1) {
            byte r = LIB.Z3_goal_inconsistent(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_goal_depth(Z3_context a0, Z3_goal a1) {
            uint r = LIB.Z3_goal_depth(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_goal_reset(Z3_context a0, Z3_goal a1) {
            LIB.Z3_goal_reset(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static uint Z3_goal_size(Z3_context a0, Z3_goal a1) {
            uint r = LIB.Z3_goal_size(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_goal_formula(Z3_context a0, Z3_goal a1, uint a2) {
            Z3_ast r = LIB.Z3_goal_formula(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_goal_num_exprs(Z3_context a0, Z3_goal a1) {
            uint r = LIB.Z3_goal_num_exprs(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_goal_is_decided_sat(Z3_context a0, Z3_goal a1) {
            byte r = LIB.Z3_goal_is_decided_sat(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_goal_is_decided_unsat(Z3_context a0, Z3_goal a1) {
            byte r = LIB.Z3_goal_is_decided_unsat(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_goal Z3_goal_translate(Z3_context a0, Z3_goal a1, Z3_context a2) {
            Z3_goal r = LIB.Z3_goal_translate(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_model Z3_goal_convert_model(Z3_context a0, Z3_goal a1, Z3_model a2) {
            Z3_model r = LIB.Z3_goal_convert_model(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_goal_to_string(Z3_context a0, Z3_goal a1) {
            IntPtr r = LIB.Z3_goal_to_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static string Z3_goal_to_dimacs_string(Z3_context a0, Z3_goal a1) {
            IntPtr r = LIB.Z3_goal_to_dimacs_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static Z3_tactic Z3_mk_tactic(Z3_context a0, string a1) {
            Z3_tactic r = LIB.Z3_mk_tactic(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_tactic_inc_ref(Z3_context a0, Z3_tactic a1) {
            LIB.Z3_tactic_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_tactic_dec_ref(Z3_context a0, Z3_tactic a1) {
            LIB.Z3_tactic_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_probe Z3_mk_probe(Z3_context a0, string a1) {
            Z3_probe r = LIB.Z3_mk_probe(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_probe_inc_ref(Z3_context a0, Z3_probe a1) {
            LIB.Z3_probe_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_probe_dec_ref(Z3_context a0, Z3_probe a1) {
            LIB.Z3_probe_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_tactic Z3_tactic_and_then(Z3_context a0, Z3_tactic a1, Z3_tactic a2) {
            Z3_tactic r = LIB.Z3_tactic_and_then(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_tactic Z3_tactic_or_else(Z3_context a0, Z3_tactic a1, Z3_tactic a2) {
            Z3_tactic r = LIB.Z3_tactic_or_else(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_tactic Z3_tactic_par_or(Z3_context a0, uint a1, [In] Z3_tactic[] a2) {
            Z3_tactic r = LIB.Z3_tactic_par_or(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_tactic Z3_tactic_par_and_then(Z3_context a0, Z3_tactic a1, Z3_tactic a2) {
            Z3_tactic r = LIB.Z3_tactic_par_and_then(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_tactic Z3_tactic_try_for(Z3_context a0, Z3_tactic a1, uint a2) {
            Z3_tactic r = LIB.Z3_tactic_try_for(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_tactic Z3_tactic_when(Z3_context a0, Z3_probe a1, Z3_tactic a2) {
            Z3_tactic r = LIB.Z3_tactic_when(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_tactic Z3_tactic_cond(Z3_context a0, Z3_probe a1, Z3_tactic a2, Z3_tactic a3) {
            Z3_tactic r = LIB.Z3_tactic_cond(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_tactic Z3_tactic_repeat(Z3_context a0, Z3_tactic a1, uint a2) {
            Z3_tactic r = LIB.Z3_tactic_repeat(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_tactic Z3_tactic_skip(Z3_context a0) {
            Z3_tactic r = LIB.Z3_tactic_skip(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_tactic Z3_tactic_fail(Z3_context a0) {
            Z3_tactic r = LIB.Z3_tactic_fail(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_tactic Z3_tactic_fail_if(Z3_context a0, Z3_probe a1) {
            Z3_tactic r = LIB.Z3_tactic_fail_if(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_tactic Z3_tactic_fail_if_not_decided(Z3_context a0) {
            Z3_tactic r = LIB.Z3_tactic_fail_if_not_decided(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_tactic Z3_tactic_using_params(Z3_context a0, Z3_tactic a1, Z3_params a2) {
            Z3_tactic r = LIB.Z3_tactic_using_params(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_probe Z3_probe_const(Z3_context a0, double a1) {
            Z3_probe r = LIB.Z3_probe_const(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_probe Z3_probe_lt(Z3_context a0, Z3_probe a1, Z3_probe a2) {
            Z3_probe r = LIB.Z3_probe_lt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_probe Z3_probe_gt(Z3_context a0, Z3_probe a1, Z3_probe a2) {
            Z3_probe r = LIB.Z3_probe_gt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_probe Z3_probe_le(Z3_context a0, Z3_probe a1, Z3_probe a2) {
            Z3_probe r = LIB.Z3_probe_le(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_probe Z3_probe_ge(Z3_context a0, Z3_probe a1, Z3_probe a2) {
            Z3_probe r = LIB.Z3_probe_ge(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_probe Z3_probe_eq(Z3_context a0, Z3_probe a1, Z3_probe a2) {
            Z3_probe r = LIB.Z3_probe_eq(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_probe Z3_probe_and(Z3_context a0, Z3_probe a1, Z3_probe a2) {
            Z3_probe r = LIB.Z3_probe_and(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_probe Z3_probe_or(Z3_context a0, Z3_probe a1, Z3_probe a2) {
            Z3_probe r = LIB.Z3_probe_or(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_probe Z3_probe_not(Z3_context a0, Z3_probe a1) {
            Z3_probe r = LIB.Z3_probe_not(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_get_num_tactics(Z3_context a0) {
            uint r = LIB.Z3_get_num_tactics(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_get_tactic_name(Z3_context a0, uint a1) {
            IntPtr r = LIB.Z3_get_tactic_name(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static uint Z3_get_num_probes(Z3_context a0) {
            uint r = LIB.Z3_get_num_probes(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_get_probe_name(Z3_context a0, uint a1) {
            IntPtr r = LIB.Z3_get_probe_name(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static string Z3_tactic_get_help(Z3_context a0, Z3_tactic a1) {
            IntPtr r = LIB.Z3_tactic_get_help(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static Z3_param_descrs Z3_tactic_get_param_descrs(Z3_context a0, Z3_tactic a1) {
            Z3_param_descrs r = LIB.Z3_tactic_get_param_descrs(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_tactic_get_descr(Z3_context a0, string a1) {
            IntPtr r = LIB.Z3_tactic_get_descr(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static string Z3_probe_get_descr(Z3_context a0, string a1) {
            IntPtr r = LIB.Z3_probe_get_descr(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static double Z3_probe_apply(Z3_context a0, Z3_probe a1, Z3_goal a2) {
            double r = LIB.Z3_probe_apply(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_apply_result Z3_tactic_apply(Z3_context a0, Z3_tactic a1, Z3_goal a2) {
            Z3_apply_result r = LIB.Z3_tactic_apply(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_apply_result Z3_tactic_apply_ex(Z3_context a0, Z3_tactic a1, Z3_goal a2, Z3_params a3) {
            Z3_apply_result r = LIB.Z3_tactic_apply_ex(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_apply_result_inc_ref(Z3_context a0, Z3_apply_result a1) {
            LIB.Z3_apply_result_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_apply_result_dec_ref(Z3_context a0, Z3_apply_result a1) {
            LIB.Z3_apply_result_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static string Z3_apply_result_to_string(Z3_context a0, Z3_apply_result a1) {
            IntPtr r = LIB.Z3_apply_result_to_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static uint Z3_apply_result_get_num_subgoals(Z3_context a0, Z3_apply_result a1) {
            uint r = LIB.Z3_apply_result_get_num_subgoals(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_goal Z3_apply_result_get_subgoal(Z3_context a0, Z3_apply_result a1, uint a2) {
            Z3_goal r = LIB.Z3_apply_result_get_subgoal(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_solver Z3_mk_solver(Z3_context a0) {
            Z3_solver r = LIB.Z3_mk_solver(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_solver Z3_mk_simple_solver(Z3_context a0) {
            Z3_solver r = LIB.Z3_mk_simple_solver(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_solver Z3_mk_solver_for_logic(Z3_context a0, IntPtr a1) {
            Z3_solver r = LIB.Z3_mk_solver_for_logic(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_solver Z3_mk_solver_from_tactic(Z3_context a0, Z3_tactic a1) {
            Z3_solver r = LIB.Z3_mk_solver_from_tactic(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_solver Z3_solver_translate(Z3_context a0, Z3_solver a1, Z3_context a2) {
            Z3_solver r = LIB.Z3_solver_translate(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_solver_import_model_converter(Z3_context a0, Z3_solver a1, Z3_solver a2) {
            LIB.Z3_solver_import_model_converter(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static string Z3_solver_get_help(Z3_context a0, Z3_solver a1) {
            IntPtr r = LIB.Z3_solver_get_help(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static Z3_param_descrs Z3_solver_get_param_descrs(Z3_context a0, Z3_solver a1) {
            Z3_param_descrs r = LIB.Z3_solver_get_param_descrs(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_solver_set_params(Z3_context a0, Z3_solver a1, Z3_params a2) {
            LIB.Z3_solver_set_params(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_solver_inc_ref(Z3_context a0, Z3_solver a1) {
            LIB.Z3_solver_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_solver_dec_ref(Z3_context a0, Z3_solver a1) {
            LIB.Z3_solver_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_solver_interrupt(Z3_context a0, Z3_solver a1) {
            LIB.Z3_solver_interrupt(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_solver_push(Z3_context a0, Z3_solver a1) {
            LIB.Z3_solver_push(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_solver_pop(Z3_context a0, Z3_solver a1, uint a2) {
            LIB.Z3_solver_pop(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_solver_reset(Z3_context a0, Z3_solver a1) {
            LIB.Z3_solver_reset(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static uint Z3_solver_get_num_scopes(Z3_context a0, Z3_solver a1) {
            uint r = LIB.Z3_solver_get_num_scopes(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_solver_assert(Z3_context a0, Z3_solver a1, Z3_ast a2) {
            LIB.Z3_solver_assert(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_solver_assert_and_track(Z3_context a0, Z3_solver a1, Z3_ast a2, Z3_ast a3) {
            LIB.Z3_solver_assert_and_track(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_solver_from_file(Z3_context a0, Z3_solver a1, string a2) {
            LIB.Z3_solver_from_file(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_solver_from_string(Z3_context a0, Z3_solver a1, string a2) {
            LIB.Z3_solver_from_string(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_ast_vector Z3_solver_get_assertions(Z3_context a0, Z3_solver a1) {
            Z3_ast_vector r = LIB.Z3_solver_get_assertions(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_solver_get_units(Z3_context a0, Z3_solver a1) {
            Z3_ast_vector r = LIB.Z3_solver_get_units(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_solver_get_trail(Z3_context a0, Z3_solver a1) {
            Z3_ast_vector r = LIB.Z3_solver_get_trail(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_solver_get_non_units(Z3_context a0, Z3_solver a1) {
            Z3_ast_vector r = LIB.Z3_solver_get_non_units(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_solver_get_levels(Z3_context a0, Z3_solver a1, Z3_ast_vector a2, uint a3, [In] uint[] a4) {
            LIB.Z3_solver_get_levels(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static int Z3_solver_check(Z3_context a0, Z3_solver a1) {
            int r = LIB.Z3_solver_check(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static int Z3_solver_check_assumptions(Z3_context a0, Z3_solver a1, uint a2, [In] Z3_ast[] a3) {
            int r = LIB.Z3_solver_check_assumptions(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static int Z3_get_implied_equalities(Z3_context a0, Z3_solver a1, uint a2, [In] Z3_ast[] a3, [Out] uint[] a4) {
            int r = LIB.Z3_get_implied_equalities(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static int Z3_solver_get_consequences(Z3_context a0, Z3_solver a1, Z3_ast_vector a2, Z3_ast_vector a3, Z3_ast_vector a4) {
            int r = LIB.Z3_solver_get_consequences(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_solver_cube(Z3_context a0, Z3_solver a1, Z3_ast_vector a2, uint a3) {
            Z3_ast_vector r = LIB.Z3_solver_cube(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_model Z3_solver_get_model(Z3_context a0, Z3_solver a1) {
            Z3_model r = LIB.Z3_solver_get_model(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_solver_get_proof(Z3_context a0, Z3_solver a1) {
            Z3_ast r = LIB.Z3_solver_get_proof(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_solver_get_unsat_core(Z3_context a0, Z3_solver a1) {
            Z3_ast_vector r = LIB.Z3_solver_get_unsat_core(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_solver_get_reason_unknown(Z3_context a0, Z3_solver a1) {
            IntPtr r = LIB.Z3_solver_get_reason_unknown(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static Z3_stats Z3_solver_get_statistics(Z3_context a0, Z3_solver a1) {
            Z3_stats r = LIB.Z3_solver_get_statistics(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_solver_to_string(Z3_context a0, Z3_solver a1) {
            IntPtr r = LIB.Z3_solver_to_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static string Z3_solver_to_dimacs_string(Z3_context a0, Z3_solver a1, byte a2) {
            IntPtr r = LIB.Z3_solver_to_dimacs_string(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static string Z3_stats_to_string(Z3_context a0, Z3_stats a1) {
            IntPtr r = LIB.Z3_stats_to_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static void Z3_stats_inc_ref(Z3_context a0, Z3_stats a1) {
            LIB.Z3_stats_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_stats_dec_ref(Z3_context a0, Z3_stats a1) {
            LIB.Z3_stats_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static uint Z3_stats_size(Z3_context a0, Z3_stats a1) {
            uint r = LIB.Z3_stats_size(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_stats_get_key(Z3_context a0, Z3_stats a1, uint a2) {
            IntPtr r = LIB.Z3_stats_get_key(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static byte Z3_stats_is_uint(Z3_context a0, Z3_stats a1, uint a2) {
            byte r = LIB.Z3_stats_is_uint(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_stats_is_double(Z3_context a0, Z3_stats a1, uint a2) {
            byte r = LIB.Z3_stats_is_double(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_stats_get_uint_value(Z3_context a0, Z3_stats a1, uint a2) {
            uint r = LIB.Z3_stats_get_uint_value(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static double Z3_stats_get_double_value(Z3_context a0, Z3_stats a1, uint a2) {
            double r = LIB.Z3_stats_get_double_value(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static UInt64 Z3_get_estimated_alloc_size() {
            UInt64 r = LIB.Z3_get_estimated_alloc_size();
            return r;
        }

        public static Z3_ast_vector Z3_mk_ast_vector(Z3_context a0) {
            Z3_ast_vector r = LIB.Z3_mk_ast_vector(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_ast_vector_inc_ref(Z3_context a0, Z3_ast_vector a1) {
            LIB.Z3_ast_vector_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_ast_vector_dec_ref(Z3_context a0, Z3_ast_vector a1) {
            LIB.Z3_ast_vector_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static uint Z3_ast_vector_size(Z3_context a0, Z3_ast_vector a1) {
            uint r = LIB.Z3_ast_vector_size(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_ast_vector_get(Z3_context a0, Z3_ast_vector a1, uint a2) {
            Z3_ast r = LIB.Z3_ast_vector_get(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_ast_vector_set(Z3_context a0, Z3_ast_vector a1, uint a2, Z3_ast a3) {
            LIB.Z3_ast_vector_set(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_ast_vector_resize(Z3_context a0, Z3_ast_vector a1, uint a2) {
            LIB.Z3_ast_vector_resize(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_ast_vector_push(Z3_context a0, Z3_ast_vector a1, Z3_ast a2) {
            LIB.Z3_ast_vector_push(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_ast_vector Z3_ast_vector_translate(Z3_context a0, Z3_ast_vector a1, Z3_context a2) {
            Z3_ast_vector r = LIB.Z3_ast_vector_translate(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_ast_vector_to_string(Z3_context a0, Z3_ast_vector a1) {
            IntPtr r = LIB.Z3_ast_vector_to_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static Z3_ast_map Z3_mk_ast_map(Z3_context a0) {
            Z3_ast_map r = LIB.Z3_mk_ast_map(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_ast_map_inc_ref(Z3_context a0, Z3_ast_map a1) {
            LIB.Z3_ast_map_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_ast_map_dec_ref(Z3_context a0, Z3_ast_map a1) {
            LIB.Z3_ast_map_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static byte Z3_ast_map_contains(Z3_context a0, Z3_ast_map a1, Z3_ast a2) {
            byte r = LIB.Z3_ast_map_contains(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_ast_map_find(Z3_context a0, Z3_ast_map a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_ast_map_find(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_ast_map_insert(Z3_context a0, Z3_ast_map a1, Z3_ast a2, Z3_ast a3) {
            LIB.Z3_ast_map_insert(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_ast_map_erase(Z3_context a0, Z3_ast_map a1, Z3_ast a2) {
            LIB.Z3_ast_map_erase(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_ast_map_reset(Z3_context a0, Z3_ast_map a1) {
            LIB.Z3_ast_map_reset(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static uint Z3_ast_map_size(Z3_context a0, Z3_ast_map a1) {
            uint r = LIB.Z3_ast_map_size(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_ast_map_keys(Z3_context a0, Z3_ast_map a1) {
            Z3_ast_vector r = LIB.Z3_ast_map_keys(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_ast_map_to_string(Z3_context a0, Z3_ast_map a1) {
            IntPtr r = LIB.Z3_ast_map_to_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static byte Z3_algebraic_is_value(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_algebraic_is_value(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_algebraic_is_pos(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_algebraic_is_pos(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_algebraic_is_neg(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_algebraic_is_neg(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_algebraic_is_zero(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_algebraic_is_zero(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static int Z3_algebraic_sign(Z3_context a0, Z3_ast a1) {
            int r = LIB.Z3_algebraic_sign(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_algebraic_add(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_algebraic_add(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_algebraic_sub(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_algebraic_sub(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_algebraic_mul(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_algebraic_mul(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_algebraic_div(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_algebraic_div(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_algebraic_root(Z3_context a0, Z3_ast a1, uint a2) {
            Z3_ast r = LIB.Z3_algebraic_root(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_algebraic_power(Z3_context a0, Z3_ast a1, uint a2) {
            Z3_ast r = LIB.Z3_algebraic_power(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_algebraic_lt(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            byte r = LIB.Z3_algebraic_lt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_algebraic_gt(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            byte r = LIB.Z3_algebraic_gt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_algebraic_le(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            byte r = LIB.Z3_algebraic_le(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_algebraic_ge(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            byte r = LIB.Z3_algebraic_ge(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_algebraic_eq(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            byte r = LIB.Z3_algebraic_eq(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_algebraic_neq(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            byte r = LIB.Z3_algebraic_neq(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_algebraic_roots(Z3_context a0, Z3_ast a1, uint a2, [In] Z3_ast[] a3) {
            Z3_ast_vector r = LIB.Z3_algebraic_roots(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static int Z3_algebraic_eval(Z3_context a0, Z3_ast a1, uint a2, [In] Z3_ast[] a3) {
            int r = LIB.Z3_algebraic_eval(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_algebraic_get_poly(Z3_context a0, Z3_ast a1) {
            Z3_ast_vector r = LIB.Z3_algebraic_get_poly(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_algebraic_get_i(Z3_context a0, Z3_ast a1) {
            uint r = LIB.Z3_algebraic_get_i(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_polynomial_subresultants(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3) {
            Z3_ast_vector r = LIB.Z3_polynomial_subresultants(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_rcf_del(Z3_context a0, Z3_rcf_num a1) {
            LIB.Z3_rcf_del(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_rcf_num Z3_rcf_mk_rational(Z3_context a0, string a1) {
            Z3_rcf_num r = LIB.Z3_rcf_mk_rational(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_rcf_num Z3_rcf_mk_small_int(Z3_context a0, int a1) {
            Z3_rcf_num r = LIB.Z3_rcf_mk_small_int(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_rcf_num Z3_rcf_mk_pi(Z3_context a0) {
            Z3_rcf_num r = LIB.Z3_rcf_mk_pi(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_rcf_num Z3_rcf_mk_e(Z3_context a0) {
            Z3_rcf_num r = LIB.Z3_rcf_mk_e(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_rcf_num Z3_rcf_mk_infinitesimal(Z3_context a0) {
            Z3_rcf_num r = LIB.Z3_rcf_mk_infinitesimal(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_rcf_mk_roots(Z3_context a0, uint a1, [In] Z3_rcf_num[] a2, [Out] Z3_rcf_num[] a3) {
            uint r = LIB.Z3_rcf_mk_roots(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_rcf_num Z3_rcf_add(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2) {
            Z3_rcf_num r = LIB.Z3_rcf_add(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_rcf_num Z3_rcf_sub(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2) {
            Z3_rcf_num r = LIB.Z3_rcf_sub(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_rcf_num Z3_rcf_mul(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2) {
            Z3_rcf_num r = LIB.Z3_rcf_mul(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_rcf_num Z3_rcf_div(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2) {
            Z3_rcf_num r = LIB.Z3_rcf_div(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_rcf_num Z3_rcf_neg(Z3_context a0, Z3_rcf_num a1) {
            Z3_rcf_num r = LIB.Z3_rcf_neg(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_rcf_num Z3_rcf_inv(Z3_context a0, Z3_rcf_num a1) {
            Z3_rcf_num r = LIB.Z3_rcf_inv(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_rcf_num Z3_rcf_power(Z3_context a0, Z3_rcf_num a1, uint a2) {
            Z3_rcf_num r = LIB.Z3_rcf_power(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_rcf_lt(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2) {
            byte r = LIB.Z3_rcf_lt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_rcf_gt(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2) {
            byte r = LIB.Z3_rcf_gt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_rcf_le(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2) {
            byte r = LIB.Z3_rcf_le(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_rcf_ge(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2) {
            byte r = LIB.Z3_rcf_ge(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_rcf_eq(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2) {
            byte r = LIB.Z3_rcf_eq(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_rcf_neq(Z3_context a0, Z3_rcf_num a1, Z3_rcf_num a2) {
            byte r = LIB.Z3_rcf_neq(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_rcf_num_to_string(Z3_context a0, Z3_rcf_num a1, byte a2, byte a3) {
            IntPtr r = LIB.Z3_rcf_num_to_string(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static string Z3_rcf_num_to_decimal_string(Z3_context a0, Z3_rcf_num a1, uint a2) {
            IntPtr r = LIB.Z3_rcf_num_to_decimal_string(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static void Z3_rcf_get_numerator_denominator(Z3_context a0, Z3_rcf_num a1, [In, Out] ref Z3_rcf_num a2, [In, Out] ref Z3_rcf_num a3) {
            LIB.Z3_rcf_get_numerator_denominator(a0, a1, ref a2, ref a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_fixedpoint Z3_mk_fixedpoint(Z3_context a0) {
            Z3_fixedpoint r = LIB.Z3_mk_fixedpoint(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_fixedpoint_inc_ref(Z3_context a0, Z3_fixedpoint a1) {
            LIB.Z3_fixedpoint_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_fixedpoint_dec_ref(Z3_context a0, Z3_fixedpoint a1) {
            LIB.Z3_fixedpoint_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_fixedpoint_add_rule(Z3_context a0, Z3_fixedpoint a1, Z3_ast a2, IntPtr a3) {
            LIB.Z3_fixedpoint_add_rule(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_fixedpoint_add_fact(Z3_context a0, Z3_fixedpoint a1, Z3_func_decl a2, uint a3, [In] uint[] a4) {
            LIB.Z3_fixedpoint_add_fact(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_fixedpoint_assert(Z3_context a0, Z3_fixedpoint a1, Z3_ast a2) {
            LIB.Z3_fixedpoint_assert(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static int Z3_fixedpoint_query(Z3_context a0, Z3_fixedpoint a1, Z3_ast a2) {
            int r = LIB.Z3_fixedpoint_query(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static int Z3_fixedpoint_query_relations(Z3_context a0, Z3_fixedpoint a1, uint a2, [In] Z3_func_decl[] a3) {
            int r = LIB.Z3_fixedpoint_query_relations(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_fixedpoint_get_answer(Z3_context a0, Z3_fixedpoint a1) {
            Z3_ast r = LIB.Z3_fixedpoint_get_answer(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_fixedpoint_get_reason_unknown(Z3_context a0, Z3_fixedpoint a1) {
            IntPtr r = LIB.Z3_fixedpoint_get_reason_unknown(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static void Z3_fixedpoint_update_rule(Z3_context a0, Z3_fixedpoint a1, Z3_ast a2, IntPtr a3) {
            LIB.Z3_fixedpoint_update_rule(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static uint Z3_fixedpoint_get_num_levels(Z3_context a0, Z3_fixedpoint a1, Z3_func_decl a2) {
            uint r = LIB.Z3_fixedpoint_get_num_levels(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_fixedpoint_get_cover_delta(Z3_context a0, Z3_fixedpoint a1, int a2, Z3_func_decl a3) {
            Z3_ast r = LIB.Z3_fixedpoint_get_cover_delta(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_fixedpoint_add_cover(Z3_context a0, Z3_fixedpoint a1, int a2, Z3_func_decl a3, Z3_ast a4) {
            LIB.Z3_fixedpoint_add_cover(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_stats Z3_fixedpoint_get_statistics(Z3_context a0, Z3_fixedpoint a1) {
            Z3_stats r = LIB.Z3_fixedpoint_get_statistics(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_fixedpoint_register_relation(Z3_context a0, Z3_fixedpoint a1, Z3_func_decl a2) {
            LIB.Z3_fixedpoint_register_relation(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_fixedpoint_set_predicate_representation(Z3_context a0, Z3_fixedpoint a1, Z3_func_decl a2, uint a3, [In] IntPtr[] a4) {
            LIB.Z3_fixedpoint_set_predicate_representation(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_ast_vector Z3_fixedpoint_get_rules(Z3_context a0, Z3_fixedpoint a1) {
            Z3_ast_vector r = LIB.Z3_fixedpoint_get_rules(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_fixedpoint_get_assertions(Z3_context a0, Z3_fixedpoint a1) {
            Z3_ast_vector r = LIB.Z3_fixedpoint_get_assertions(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_fixedpoint_set_params(Z3_context a0, Z3_fixedpoint a1, Z3_params a2) {
            LIB.Z3_fixedpoint_set_params(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static string Z3_fixedpoint_get_help(Z3_context a0, Z3_fixedpoint a1) {
            IntPtr r = LIB.Z3_fixedpoint_get_help(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static Z3_param_descrs Z3_fixedpoint_get_param_descrs(Z3_context a0, Z3_fixedpoint a1) {
            Z3_param_descrs r = LIB.Z3_fixedpoint_get_param_descrs(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_fixedpoint_to_string(Z3_context a0, Z3_fixedpoint a1, uint a2, [In] Z3_ast[] a3) {
            IntPtr r = LIB.Z3_fixedpoint_to_string(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static Z3_ast_vector Z3_fixedpoint_from_string(Z3_context a0, Z3_fixedpoint a1, string a2) {
            Z3_ast_vector r = LIB.Z3_fixedpoint_from_string(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_fixedpoint_from_file(Z3_context a0, Z3_fixedpoint a1, string a2) {
            Z3_ast_vector r = LIB.Z3_fixedpoint_from_file(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_optimize Z3_mk_optimize(Z3_context a0) {
            Z3_optimize r = LIB.Z3_mk_optimize(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_optimize_inc_ref(Z3_context a0, Z3_optimize a1) {
            LIB.Z3_optimize_inc_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_optimize_dec_ref(Z3_context a0, Z3_optimize a1) {
            LIB.Z3_optimize_dec_ref(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_optimize_assert(Z3_context a0, Z3_optimize a1, Z3_ast a2) {
            LIB.Z3_optimize_assert(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_optimize_assert_and_track(Z3_context a0, Z3_optimize a1, Z3_ast a2, Z3_ast a3) {
            LIB.Z3_optimize_assert_and_track(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static uint Z3_optimize_assert_soft(Z3_context a0, Z3_optimize a1, Z3_ast a2, string a3, IntPtr a4) {
            uint r = LIB.Z3_optimize_assert_soft(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_optimize_maximize(Z3_context a0, Z3_optimize a1, Z3_ast a2) {
            uint r = LIB.Z3_optimize_maximize(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_optimize_minimize(Z3_context a0, Z3_optimize a1, Z3_ast a2) {
            uint r = LIB.Z3_optimize_minimize(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_optimize_push(Z3_context a0, Z3_optimize a1) {
            LIB.Z3_optimize_push(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_optimize_pop(Z3_context a0, Z3_optimize a1) {
            LIB.Z3_optimize_pop(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static int Z3_optimize_check(Z3_context a0, Z3_optimize a1, uint a2, [In] Z3_ast[] a3) {
            int r = LIB.Z3_optimize_check(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_optimize_get_reason_unknown(Z3_context a0, Z3_optimize a1) {
            IntPtr r = LIB.Z3_optimize_get_reason_unknown(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static Z3_model Z3_optimize_get_model(Z3_context a0, Z3_optimize a1) {
            Z3_model r = LIB.Z3_optimize_get_model(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_optimize_get_unsat_core(Z3_context a0, Z3_optimize a1) {
            Z3_ast_vector r = LIB.Z3_optimize_get_unsat_core(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_optimize_set_params(Z3_context a0, Z3_optimize a1, Z3_params a2) {
            LIB.Z3_optimize_set_params(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_param_descrs Z3_optimize_get_param_descrs(Z3_context a0, Z3_optimize a1) {
            Z3_param_descrs r = LIB.Z3_optimize_get_param_descrs(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_optimize_get_lower(Z3_context a0, Z3_optimize a1, uint a2) {
            Z3_ast r = LIB.Z3_optimize_get_lower(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_optimize_get_upper(Z3_context a0, Z3_optimize a1, uint a2) {
            Z3_ast r = LIB.Z3_optimize_get_upper(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_optimize_get_lower_as_vector(Z3_context a0, Z3_optimize a1, uint a2) {
            Z3_ast_vector r = LIB.Z3_optimize_get_lower_as_vector(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_optimize_get_upper_as_vector(Z3_context a0, Z3_optimize a1, uint a2) {
            Z3_ast_vector r = LIB.Z3_optimize_get_upper_as_vector(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_optimize_to_string(Z3_context a0, Z3_optimize a1) {
            IntPtr r = LIB.Z3_optimize_to_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static void Z3_optimize_from_string(Z3_context a0, Z3_optimize a1, string a2) {
            LIB.Z3_optimize_from_string(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static void Z3_optimize_from_file(Z3_context a0, Z3_optimize a1, string a2) {
            LIB.Z3_optimize_from_file(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static string Z3_optimize_get_help(Z3_context a0, Z3_optimize a1) {
            IntPtr r = LIB.Z3_optimize_get_help(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static Z3_stats Z3_optimize_get_statistics(Z3_context a0, Z3_optimize a1) {
            Z3_stats r = LIB.Z3_optimize_get_statistics(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_optimize_get_assertions(Z3_context a0, Z3_optimize a1) {
            Z3_ast_vector r = LIB.Z3_optimize_get_assertions(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_optimize_get_objectives(Z3_context a0, Z3_optimize a1) {
            Z3_ast_vector r = LIB.Z3_optimize_get_objectives(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_fpa_rounding_mode_sort(Z3_context a0) {
            Z3_sort r = LIB.Z3_mk_fpa_rounding_mode_sort(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_round_nearest_ties_to_even(Z3_context a0) {
            Z3_ast r = LIB.Z3_mk_fpa_round_nearest_ties_to_even(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_rne(Z3_context a0) {
            Z3_ast r = LIB.Z3_mk_fpa_rne(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_round_nearest_ties_to_away(Z3_context a0) {
            Z3_ast r = LIB.Z3_mk_fpa_round_nearest_ties_to_away(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_rna(Z3_context a0) {
            Z3_ast r = LIB.Z3_mk_fpa_rna(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_round_toward_positive(Z3_context a0) {
            Z3_ast r = LIB.Z3_mk_fpa_round_toward_positive(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_rtp(Z3_context a0) {
            Z3_ast r = LIB.Z3_mk_fpa_rtp(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_round_toward_negative(Z3_context a0) {
            Z3_ast r = LIB.Z3_mk_fpa_round_toward_negative(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_rtn(Z3_context a0) {
            Z3_ast r = LIB.Z3_mk_fpa_rtn(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_round_toward_zero(Z3_context a0) {
            Z3_ast r = LIB.Z3_mk_fpa_round_toward_zero(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_rtz(Z3_context a0) {
            Z3_ast r = LIB.Z3_mk_fpa_rtz(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_fpa_sort(Z3_context a0, uint a1, uint a2) {
            Z3_sort r = LIB.Z3_mk_fpa_sort(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_fpa_sort_half(Z3_context a0) {
            Z3_sort r = LIB.Z3_mk_fpa_sort_half(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_fpa_sort_16(Z3_context a0) {
            Z3_sort r = LIB.Z3_mk_fpa_sort_16(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_fpa_sort_single(Z3_context a0) {
            Z3_sort r = LIB.Z3_mk_fpa_sort_single(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_fpa_sort_32(Z3_context a0) {
            Z3_sort r = LIB.Z3_mk_fpa_sort_32(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_fpa_sort_double(Z3_context a0) {
            Z3_sort r = LIB.Z3_mk_fpa_sort_double(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_fpa_sort_64(Z3_context a0) {
            Z3_sort r = LIB.Z3_mk_fpa_sort_64(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_fpa_sort_quadruple(Z3_context a0) {
            Z3_sort r = LIB.Z3_mk_fpa_sort_quadruple(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_sort Z3_mk_fpa_sort_128(Z3_context a0) {
            Z3_sort r = LIB.Z3_mk_fpa_sort_128(a0);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_nan(Z3_context a0, Z3_sort a1) {
            Z3_ast r = LIB.Z3_mk_fpa_nan(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_inf(Z3_context a0, Z3_sort a1, byte a2) {
            Z3_ast r = LIB.Z3_mk_fpa_inf(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_zero(Z3_context a0, Z3_sort a1, byte a2) {
            Z3_ast r = LIB.Z3_mk_fpa_zero(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_fp(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3) {
            Z3_ast r = LIB.Z3_mk_fpa_fp(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_numeral_float(Z3_context a0, float a1, Z3_sort a2) {
            Z3_ast r = LIB.Z3_mk_fpa_numeral_float(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_numeral_double(Z3_context a0, double a1, Z3_sort a2) {
            Z3_ast r = LIB.Z3_mk_fpa_numeral_double(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_numeral_int(Z3_context a0, int a1, Z3_sort a2) {
            Z3_ast r = LIB.Z3_mk_fpa_numeral_int(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_numeral_int_uint(Z3_context a0, byte a1, int a2, uint a3, Z3_sort a4) {
            Z3_ast r = LIB.Z3_mk_fpa_numeral_int_uint(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_numeral_int64_uint64(Z3_context a0, byte a1, Int64 a2, UInt64 a3, Z3_sort a4) {
            Z3_ast r = LIB.Z3_mk_fpa_numeral_int64_uint64(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_abs(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_fpa_abs(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_neg(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_fpa_neg(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_add(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3) {
            Z3_ast r = LIB.Z3_mk_fpa_add(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_sub(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3) {
            Z3_ast r = LIB.Z3_mk_fpa_sub(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_mul(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3) {
            Z3_ast r = LIB.Z3_mk_fpa_mul(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_div(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3) {
            Z3_ast r = LIB.Z3_mk_fpa_div(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_fma(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3, Z3_ast a4) {
            Z3_ast r = LIB.Z3_mk_fpa_fma(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_sqrt(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_fpa_sqrt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_rem(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_fpa_rem(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_round_to_integral(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_fpa_round_to_integral(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_min(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_fpa_min(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_max(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_fpa_max(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_leq(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_fpa_leq(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_lt(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_fpa_lt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_geq(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_fpa_geq(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_gt(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_fpa_gt(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_eq(Z3_context a0, Z3_ast a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_mk_fpa_eq(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_is_normal(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_fpa_is_normal(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_is_subnormal(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_fpa_is_subnormal(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_is_zero(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_fpa_is_zero(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_is_infinite(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_fpa_is_infinite(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_is_nan(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_fpa_is_nan(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_is_negative(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_fpa_is_negative(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_is_positive(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_fpa_is_positive(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_to_fp_bv(Z3_context a0, Z3_ast a1, Z3_sort a2) {
            Z3_ast r = LIB.Z3_mk_fpa_to_fp_bv(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_to_fp_float(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_sort a3) {
            Z3_ast r = LIB.Z3_mk_fpa_to_fp_float(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_to_fp_real(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_sort a3) {
            Z3_ast r = LIB.Z3_mk_fpa_to_fp_real(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_to_fp_signed(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_sort a3) {
            Z3_ast r = LIB.Z3_mk_fpa_to_fp_signed(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_to_fp_unsigned(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_sort a3) {
            Z3_ast r = LIB.Z3_mk_fpa_to_fp_unsigned(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_to_ubv(Z3_context a0, Z3_ast a1, Z3_ast a2, uint a3) {
            Z3_ast r = LIB.Z3_mk_fpa_to_ubv(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_to_sbv(Z3_context a0, Z3_ast a1, Z3_ast a2, uint a3) {
            Z3_ast r = LIB.Z3_mk_fpa_to_sbv(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_to_real(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_fpa_to_real(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_fpa_get_ebits(Z3_context a0, Z3_sort a1) {
            uint r = LIB.Z3_fpa_get_ebits(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static uint Z3_fpa_get_sbits(Z3_context a0, Z3_sort a1) {
            uint r = LIB.Z3_fpa_get_sbits(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_fpa_is_numeral_nan(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_fpa_is_numeral_nan(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_fpa_is_numeral_inf(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_fpa_is_numeral_inf(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_fpa_is_numeral_zero(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_fpa_is_numeral_zero(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_fpa_is_numeral_normal(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_fpa_is_numeral_normal(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_fpa_is_numeral_subnormal(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_fpa_is_numeral_subnormal(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_fpa_is_numeral_positive(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_fpa_is_numeral_positive(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_fpa_is_numeral_negative(Z3_context a0, Z3_ast a1) {
            byte r = LIB.Z3_fpa_is_numeral_negative(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_fpa_get_numeral_sign_bv(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_fpa_get_numeral_sign_bv(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_fpa_get_numeral_significand_bv(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_fpa_get_numeral_significand_bv(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static byte Z3_fpa_get_numeral_sign(Z3_context a0, Z3_ast a1, [In, Out] ref int a2) {
            byte r = LIB.Z3_fpa_get_numeral_sign(a0, a1, ref a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_fpa_get_numeral_significand_string(Z3_context a0, Z3_ast a1) {
            IntPtr r = LIB.Z3_fpa_get_numeral_significand_string(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static byte Z3_fpa_get_numeral_significand_uint64(Z3_context a0, Z3_ast a1, [In, Out] ref UInt64 a2) {
            byte r = LIB.Z3_fpa_get_numeral_significand_uint64(a0, a1, ref a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static string Z3_fpa_get_numeral_exponent_string(Z3_context a0, Z3_ast a1, byte a2) {
            IntPtr r = LIB.Z3_fpa_get_numeral_exponent_string(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return Marshal.PtrToStringAnsi(r);
        }

        public static byte Z3_fpa_get_numeral_exponent_int64(Z3_context a0, Z3_ast a1, [In, Out] ref Int64 a2, byte a3) {
            byte r = LIB.Z3_fpa_get_numeral_exponent_int64(a0, a1, ref a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_fpa_get_numeral_exponent_bv(Z3_context a0, Z3_ast a1, byte a2) {
            Z3_ast r = LIB.Z3_fpa_get_numeral_exponent_bv(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_to_ieee_bv(Z3_context a0, Z3_ast a1) {
            Z3_ast r = LIB.Z3_mk_fpa_to_ieee_bv(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_mk_fpa_to_fp_int_real(Z3_context a0, Z3_ast a1, Z3_ast a2, Z3_ast a3, Z3_sort a4) {
            Z3_ast r = LIB.Z3_mk_fpa_to_fp_int_real(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static int Z3_fixedpoint_query_from_lvl(Z3_context a0, Z3_fixedpoint a1, Z3_ast a2, uint a3) {
            int r = LIB.Z3_fixedpoint_query_from_lvl(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_fixedpoint_get_ground_sat_answer(Z3_context a0, Z3_fixedpoint a1) {
            Z3_ast r = LIB.Z3_fixedpoint_get_ground_sat_answer(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast_vector Z3_fixedpoint_get_rules_along_trace(Z3_context a0, Z3_fixedpoint a1) {
            Z3_ast_vector r = LIB.Z3_fixedpoint_get_rules_along_trace(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static IntPtr Z3_fixedpoint_get_rule_names_along_trace(Z3_context a0, Z3_fixedpoint a1) {
            IntPtr r = LIB.Z3_fixedpoint_get_rule_names_along_trace(a0, a1);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static void Z3_fixedpoint_add_invariant(Z3_context a0, Z3_fixedpoint a1, Z3_func_decl a2, Z3_ast a3) {
            LIB.Z3_fixedpoint_add_invariant(a0, a1, a2, a3);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
        }

        public static Z3_ast Z3_fixedpoint_get_reachable(Z3_context a0, Z3_fixedpoint a1, Z3_func_decl a2) {
            Z3_ast r = LIB.Z3_fixedpoint_get_reachable(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_qe_model_project(Z3_context a0, Z3_model a1, uint a2, [In] Z3_app[] a3, Z3_ast a4) {
            Z3_ast r = LIB.Z3_qe_model_project(a0, a1, a2, a3, a4);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_qe_model_project_skolem(Z3_context a0, Z3_model a1, uint a2, [In] Z3_app[] a3, Z3_ast a4, Z3_ast_map a5) {
            Z3_ast r = LIB.Z3_qe_model_project_skolem(a0, a1, a2, a3, a4, a5);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_model_extrapolate(Z3_context a0, Z3_model a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_model_extrapolate(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

        public static Z3_ast Z3_qe_lite(Z3_context a0, Z3_ast_vector a1, Z3_ast a2) {
            Z3_ast r = LIB.Z3_qe_lite(a0, a1, a2);
            Z3_error_code err = (Z3_error_code)LIB.Z3_get_error_code(a0);
            if (err != Z3_error_code.Z3_OK)
                throw new Z3Exception(Marshal.PtrToStringAnsi(LIB.Z3_get_error_msg(a0, (uint)err)));
            return r;
        }

    }

}

