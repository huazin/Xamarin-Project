/* This source code was produced by mkbundle, do not edit */

#ifndef NULL
#define NULL (void *)0
#endif

typedef struct {
	const char *name;
	const unsigned char *data;
	const unsigned int size;
} MonoBundledAssembly;
void          mono_register_bundled_assemblies (const MonoBundledAssembly **assemblies);
void          mono_register_config_for_assembly (const char* assembly_name, const char* config_xml);

typedef struct _compressed_data {
	MonoBundledAssembly assembly;
	int compressed_size;
} CompressedAssembly;

extern const unsigned char assembly_data_GuideForDDOn_Droid_dll [];
static CompressedAssembly assembly_bundle_GuideForDDOn_Droid_dll = {{"GuideForDDOn.Droid.dll", assembly_data_GuideForDDOn_Droid_dll, 124928}, 41926};
extern const unsigned char assembly_data_FormsViewGroup_dll [];
static CompressedAssembly assembly_bundle_FormsViewGroup_dll = {{"FormsViewGroup.dll", assembly_data_FormsViewGroup_dll, 10752}, 4231};
extern const unsigned char assembly_data_SQLite_net_dll [];
static CompressedAssembly assembly_bundle_SQLite_net_dll = {{"SQLite-net.dll", assembly_data_SQLite_net_dll, 34304}, 15808};
extern const unsigned char assembly_data_SQLitePCLRaw_batteries_v2_dll [];
static CompressedAssembly assembly_bundle_SQLitePCLRaw_batteries_v2_dll = {{"SQLitePCLRaw.batteries_v2.dll", assembly_data_SQLitePCLRaw_batteries_v2_dll, 5120}, 1907};
extern const unsigned char assembly_data_SQLitePCLRaw_core_dll [];
static CompressedAssembly assembly_bundle_SQLitePCLRaw_core_dll = {{"SQLitePCLRaw.core.dll", assembly_data_SQLitePCLRaw_core_dll, 27136}, 8302};
extern const unsigned char assembly_data_SQLitePCLRaw_provider_e_sqlite3_dll [];
static CompressedAssembly assembly_bundle_SQLitePCLRaw_provider_e_sqlite3_dll = {{"SQLitePCLRaw.provider.e_sqlite3.dll", assembly_data_SQLitePCLRaw_provider_e_sqlite3_dll, 39936}, 14766};
extern const unsigned char assembly_data_Xamarin_Android_Support_Animated_Vector_Drawable_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Animated_Vector_Drawable_dll = {{"Xamarin.Android.Support.Animated.Vector.Drawable.dll", assembly_data_Xamarin_Android_Support_Animated_Vector_Drawable_dll, 5632}, 1912};
extern const unsigned char assembly_data_Xamarin_Android_Support_Design_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Design_dll = {{"Xamarin.Android.Support.Design.dll", assembly_data_Xamarin_Android_Support_Design_dll, 40960}, 12206};
extern const unsigned char assembly_data_Xamarin_Android_Support_v4_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v4_dll = {{"Xamarin.Android.Support.v4.dll", assembly_data_Xamarin_Android_Support_v4_dll, 465408}, 109823};
extern const unsigned char assembly_data_Xamarin_Android_Support_v7_AppCompat_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v7_AppCompat_dll = {{"Xamarin.Android.Support.v7.AppCompat.dll", assembly_data_Xamarin_Android_Support_v7_AppCompat_dll, 283648}, 69511};
extern const unsigned char assembly_data_Xamarin_Android_Support_v7_CardView_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v7_CardView_dll = {{"Xamarin.Android.Support.v7.CardView.dll", assembly_data_Xamarin_Android_Support_v7_CardView_dll, 26624}, 8481};
extern const unsigned char assembly_data_Xamarin_Android_Support_v7_MediaRouter_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v7_MediaRouter_dll = {{"Xamarin.Android.Support.v7.MediaRouter.dll", assembly_data_Xamarin_Android_Support_v7_MediaRouter_dll, 5632}, 1926};
extern const unsigned char assembly_data_Xamarin_Android_Support_v7_RecyclerView_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v7_RecyclerView_dll = {{"Xamarin.Android.Support.v7.RecyclerView.dll", assembly_data_Xamarin_Android_Support_v7_RecyclerView_dll, 5632}, 2179};
extern const unsigned char assembly_data_Xamarin_Android_Support_Vector_Drawable_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Vector_Drawable_dll = {{"Xamarin.Android.Support.Vector.Drawable.dll", assembly_data_Xamarin_Android_Support_Vector_Drawable_dll, 5120}, 1856};
extern const unsigned char assembly_data_Xamarin_Forms_Core_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Forms_Core_dll = {{"Xamarin.Forms.Core.dll", assembly_data_Xamarin_Forms_Core_dll, 573440}, 220179};
extern const unsigned char assembly_data_Xamarin_Forms_Platform_Android_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Forms_Platform_Android_dll = {{"Xamarin.Forms.Platform.Android.dll", assembly_data_Xamarin_Forms_Platform_Android_dll, 268800}, 116021};
extern const unsigned char assembly_data_Xamarin_Forms_Platform_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Forms_Platform_dll = {{"Xamarin.Forms.Platform.dll", assembly_data_Xamarin_Forms_Platform_dll, 9216}, 2174};
extern const unsigned char assembly_data_Xamarin_Forms_Xaml_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Forms_Xaml_dll = {{"Xamarin.Forms.Xaml.dll", assembly_data_Xamarin_Forms_Xaml_dll, 75264}, 32353};
extern const unsigned char assembly_data_Xamarin_GooglePlayServices_Ads_dll [];
static CompressedAssembly assembly_bundle_Xamarin_GooglePlayServices_Ads_dll = {{"Xamarin.GooglePlayServices.Ads.dll", assembly_data_Xamarin_GooglePlayServices_Ads_dll, 72704}, 19381};
extern const unsigned char assembly_data_Xamarin_GooglePlayServices_Basement_dll [];
static CompressedAssembly assembly_bundle_Xamarin_GooglePlayServices_Basement_dll = {{"Xamarin.GooglePlayServices.Basement.dll", assembly_data_Xamarin_GooglePlayServices_Basement_dll, 27648}, 5514};
extern const unsigned char assembly_data_Java_Interop_dll [];
static CompressedAssembly assembly_bundle_Java_Interop_dll = {{"Java.Interop.dll", assembly_data_Java_Interop_dll, 93696}, 28091};
extern const unsigned char assembly_data_Mono_Android_dll [];
static CompressedAssembly assembly_bundle_Mono_Android_dll = {{"Mono.Android.dll", assembly_data_Mono_Android_dll, 1473024}, 362069};
extern const unsigned char assembly_data_mscorlib_dll [];
static CompressedAssembly assembly_bundle_mscorlib_dll = {{"mscorlib.dll", assembly_data_mscorlib_dll, 2116096}, 720115};
extern const unsigned char assembly_data_System_Core_dll [];
static CompressedAssembly assembly_bundle_System_Core_dll = {{"System.Core.dll", assembly_data_System_Core_dll, 304128}, 116551};
extern const unsigned char assembly_data_System_dll [];
static CompressedAssembly assembly_bundle_System_dll = {{"System.dll", assembly_data_System_dll, 774144}, 301673};
extern const unsigned char assembly_data_System_IO_Compression_dll [];
static CompressedAssembly assembly_bundle_System_IO_Compression_dll = {{"System.IO.Compression.dll", assembly_data_System_IO_Compression_dll, 4608}, 1478};
extern const unsigned char assembly_data_System_Net_Http_dll [];
static CompressedAssembly assembly_bundle_System_Net_Http_dll = {{"System.Net.Http.dll", assembly_data_System_Net_Http_dll, 78336}, 34202};
extern const unsigned char assembly_data_System_Xml_dll [];
static CompressedAssembly assembly_bundle_System_Xml_dll = {{"System.Xml.dll", assembly_data_System_Xml_dll, 968704}, 342572};
extern const unsigned char assembly_data_System_Runtime_dll [];
static CompressedAssembly assembly_bundle_System_Runtime_dll = {{"System.Runtime.dll", assembly_data_System_Runtime_dll, 11776}, 3795};
extern const unsigned char assembly_data_System_Collections_dll [];
static CompressedAssembly assembly_bundle_System_Collections_dll = {{"System.Collections.dll", assembly_data_System_Collections_dll, 5120}, 1705};
extern const unsigned char assembly_data_System_Runtime_Extensions_dll [];
static CompressedAssembly assembly_bundle_System_Runtime_Extensions_dll = {{"System.Runtime.Extensions.dll", assembly_data_System_Runtime_Extensions_dll, 4608}, 1674};
extern const unsigned char assembly_data_System_Reflection_dll [];
static CompressedAssembly assembly_bundle_System_Reflection_dll = {{"System.Reflection.dll", assembly_data_System_Reflection_dll, 5632}, 1924};
extern const unsigned char assembly_data_System_Linq_Expressions_dll [];
static CompressedAssembly assembly_bundle_System_Linq_Expressions_dll = {{"System.Linq.Expressions.dll", assembly_data_System_Linq_Expressions_dll, 6656}, 2108};
extern const unsigned char assembly_data_System_Diagnostics_Debug_dll [];
static CompressedAssembly assembly_bundle_System_Diagnostics_Debug_dll = {{"System.Diagnostics.Debug.dll", assembly_data_System_Diagnostics_Debug_dll, 4608}, 1654};
extern const unsigned char assembly_data_System_Linq_dll [];
static CompressedAssembly assembly_bundle_System_Linq_dll = {{"System.Linq.dll", assembly_data_System_Linq_dll, 4096}, 1545};
extern const unsigned char assembly_data_System_Threading_dll [];
static CompressedAssembly assembly_bundle_System_Threading_dll = {{"System.Threading.dll", assembly_data_System_Threading_dll, 5120}, 1887};
extern const unsigned char assembly_data_System_Reflection_Extensions_dll [];
static CompressedAssembly assembly_bundle_System_Reflection_Extensions_dll = {{"System.Reflection.Extensions.dll", assembly_data_System_Reflection_Extensions_dll, 4608}, 1574};
extern const unsigned char assembly_data_System_Globalization_dll [];
static CompressedAssembly assembly_bundle_System_Globalization_dll = {{"System.Globalization.dll", assembly_data_System_Globalization_dll, 4608}, 1677};
extern const unsigned char assembly_data_System_Threading_Tasks_dll [];
static CompressedAssembly assembly_bundle_System_Threading_Tasks_dll = {{"System.Threading.Tasks.dll", assembly_data_System_Threading_Tasks_dll, 5632}, 1951};
extern const unsigned char assembly_data_System_Resources_ResourceManager_dll [];
static CompressedAssembly assembly_bundle_System_Resources_ResourceManager_dll = {{"System.Resources.ResourceManager.dll", assembly_data_System_Resources_ResourceManager_dll, 4608}, 1640};
extern const unsigned char assembly_data_System_ObjectModel_dll [];
static CompressedAssembly assembly_bundle_System_ObjectModel_dll = {{"System.ObjectModel.dll", assembly_data_System_ObjectModel_dll, 5120}, 1694};
extern const unsigned char assembly_data_System_ComponentModel_dll [];
static CompressedAssembly assembly_bundle_System_ComponentModel_dll = {{"System.ComponentModel.dll", assembly_data_System_ComponentModel_dll, 4608}, 1544};
extern const unsigned char assembly_data_System_Xml_ReaderWriter_dll [];
static CompressedAssembly assembly_bundle_System_Xml_ReaderWriter_dll = {{"System.Xml.ReaderWriter.dll", assembly_data_System_Xml_ReaderWriter_dll, 5120}, 1822};
extern const unsigned char assembly_data_System_IO_dll [];
static CompressedAssembly assembly_bundle_System_IO_dll = {{"System.IO.dll", assembly_data_System_IO_dll, 4608}, 1673};
extern const unsigned char assembly_data_System_Dynamic_Runtime_dll [];
static CompressedAssembly assembly_bundle_System_Dynamic_Runtime_dll = {{"System.Dynamic.Runtime.dll", assembly_data_System_Dynamic_Runtime_dll, 5120}, 1768};
extern const unsigned char assembly_data_System_Runtime_Serialization_dll [];
static CompressedAssembly assembly_bundle_System_Runtime_Serialization_dll = {{"System.Runtime.Serialization.dll", assembly_data_System_Runtime_Serialization_dll, 435200}, 157749};
extern const unsigned char assembly_data_System_ServiceModel_Internals_dll [];
static CompressedAssembly assembly_bundle_System_ServiceModel_Internals_dll = {{"System.ServiceModel.Internals.dll", assembly_data_System_ServiceModel_Internals_dll, 58368}, 21464};
extern const unsigned char assembly_data_System_Text_RegularExpressions_dll [];
static CompressedAssembly assembly_bundle_System_Text_RegularExpressions_dll = {{"System.Text.RegularExpressions.dll", assembly_data_System_Text_RegularExpressions_dll, 4608}, 1644};
extern const unsigned char assembly_data_System_Collections_Concurrent_dll [];
static CompressedAssembly assembly_bundle_System_Collections_Concurrent_dll = {{"System.Collections.Concurrent.dll", assembly_data_System_Collections_Concurrent_dll, 4608}, 1587};
extern const unsigned char assembly_data_System_Runtime_InteropServices_dll [];
static CompressedAssembly assembly_bundle_System_Runtime_InteropServices_dll = {{"System.Runtime.InteropServices.dll", assembly_data_System_Runtime_InteropServices_dll, 5632}, 1954};

static const CompressedAssembly *compressed [] = {
	&assembly_bundle_GuideForDDOn_Droid_dll,
	&assembly_bundle_FormsViewGroup_dll,
	&assembly_bundle_SQLite_net_dll,
	&assembly_bundle_SQLitePCLRaw_batteries_v2_dll,
	&assembly_bundle_SQLitePCLRaw_core_dll,
	&assembly_bundle_SQLitePCLRaw_provider_e_sqlite3_dll,
	&assembly_bundle_Xamarin_Android_Support_Animated_Vector_Drawable_dll,
	&assembly_bundle_Xamarin_Android_Support_Design_dll,
	&assembly_bundle_Xamarin_Android_Support_v4_dll,
	&assembly_bundle_Xamarin_Android_Support_v7_AppCompat_dll,
	&assembly_bundle_Xamarin_Android_Support_v7_CardView_dll,
	&assembly_bundle_Xamarin_Android_Support_v7_MediaRouter_dll,
	&assembly_bundle_Xamarin_Android_Support_v7_RecyclerView_dll,
	&assembly_bundle_Xamarin_Android_Support_Vector_Drawable_dll,
	&assembly_bundle_Xamarin_Forms_Core_dll,
	&assembly_bundle_Xamarin_Forms_Platform_Android_dll,
	&assembly_bundle_Xamarin_Forms_Platform_dll,
	&assembly_bundle_Xamarin_Forms_Xaml_dll,
	&assembly_bundle_Xamarin_GooglePlayServices_Ads_dll,
	&assembly_bundle_Xamarin_GooglePlayServices_Basement_dll,
	&assembly_bundle_Java_Interop_dll,
	&assembly_bundle_Mono_Android_dll,
	&assembly_bundle_mscorlib_dll,
	&assembly_bundle_System_Core_dll,
	&assembly_bundle_System_dll,
	&assembly_bundle_System_IO_Compression_dll,
	&assembly_bundle_System_Net_Http_dll,
	&assembly_bundle_System_Xml_dll,
	&assembly_bundle_System_Runtime_dll,
	&assembly_bundle_System_Collections_dll,
	&assembly_bundle_System_Runtime_Extensions_dll,
	&assembly_bundle_System_Reflection_dll,
	&assembly_bundle_System_Linq_Expressions_dll,
	&assembly_bundle_System_Diagnostics_Debug_dll,
	&assembly_bundle_System_Linq_dll,
	&assembly_bundle_System_Threading_dll,
	&assembly_bundle_System_Reflection_Extensions_dll,
	&assembly_bundle_System_Globalization_dll,
	&assembly_bundle_System_Threading_Tasks_dll,
	&assembly_bundle_System_Resources_ResourceManager_dll,
	&assembly_bundle_System_ObjectModel_dll,
	&assembly_bundle_System_ComponentModel_dll,
	&assembly_bundle_System_Xml_ReaderWriter_dll,
	&assembly_bundle_System_IO_dll,
	&assembly_bundle_System_Dynamic_Runtime_dll,
	&assembly_bundle_System_Runtime_Serialization_dll,
	&assembly_bundle_System_ServiceModel_Internals_dll,
	&assembly_bundle_System_Text_RegularExpressions_dll,
	&assembly_bundle_System_Collections_Concurrent_dll,
	&assembly_bundle_System_Runtime_InteropServices_dll,
	NULL
};

static char *image_name = "GuideForDDOn.Droid.dll";

static void install_dll_config_files (void (register_config_for_assembly_func)(const char *, const char *)) {

}

static const char *config_dir = NULL;
static MonoBundledAssembly **bundled;

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <zlib.h>

static int
my_inflate (const Byte *compr, uLong compr_len, Byte *uncompr, uLong uncompr_len)
{
	int err;
	z_stream stream;

	memset (&stream, 0, sizeof (z_stream));
	stream.next_in = (Byte *) compr;
	stream.avail_in = (uInt) compr_len;

	// http://www.zlib.net/manual.html
	err = inflateInit2 (&stream, 16+MAX_WBITS);
	if (err != Z_OK)
		return 1;

	for (;;) {
		stream.next_out = uncompr;
		stream.avail_out = (uInt) uncompr_len;
		err = inflate (&stream, Z_NO_FLUSH);
		if (err == Z_STREAM_END) break;
		if (err != Z_OK) {
			printf ("%d\n", err);
			return 2;
		}
	}

	err = inflateEnd (&stream);
	if (err != Z_OK)
		return 3;

	if (stream.total_out != uncompr_len)
		return 4;
	
	return 0;
}

void mono_mkbundle_init (void (register_bundled_assemblies_func)(const MonoBundledAssembly **), void (register_config_for_assembly_func)(const char *, const char *))
{
	CompressedAssembly **ptr;
	MonoBundledAssembly **bundled_ptr;
	Bytef *buffer;
	int nbundles;

	install_dll_config_files (register_config_for_assembly_func);

	ptr = (CompressedAssembly **) compressed;
	nbundles = 0;
	while (*ptr++ != NULL)
		nbundles++;

	bundled = (MonoBundledAssembly **) malloc (sizeof (MonoBundledAssembly *) * (nbundles + 1));
	bundled_ptr = bundled;
	ptr = (CompressedAssembly **) compressed;
	while (*ptr != NULL) {
		uLong real_size;
		uLongf zsize;
		int result;
		MonoBundledAssembly *current;

		real_size = (*ptr)->assembly.size;
		zsize = (*ptr)->compressed_size;
		buffer = (Bytef *) malloc (real_size);
		result = my_inflate ((*ptr)->assembly.data, zsize, buffer, real_size);
		if (result != 0) {
			fprintf (stderr, "mkbundle: Error %d decompressing data for %s\n", result, (*ptr)->assembly.name);
			exit (1);
		}
		(*ptr)->assembly.data = buffer;
		current = (MonoBundledAssembly *) malloc (sizeof (MonoBundledAssembly));
		memcpy (current, *ptr, sizeof (MonoBundledAssembly));
		current->name = (*ptr)->assembly.name;
		*bundled_ptr = current;
		bundled_ptr++;
		ptr++;
	}
	*bundled_ptr = NULL;
	register_bundled_assemblies_func((const MonoBundledAssembly **) bundled);
}
