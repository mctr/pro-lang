package foo;

public class SearchUtilities {
	private static SearchSpec[] commonSpecs =
		{ new SearchSpec("Google",
			"http://www.google.com/search?q="),
		new SearchSpec("AllTheWeb",
			"http://www.alltheweb.com/search?q="),
		new SearchSpec("Yahoo",
			"http://search.yahoo.com/bin/search?p="),
		new SearchSpec("AltaVista",
			"http://www.altavista.com/web/results?q="),
		new SearchSpec("Lycos",
			"search.lycos.com/default.asp?query="),
		new SearchSpec("HotBot",
			"http://hotbot.com/default.asp?query="),
		new SearchSpec("MSN",
			"http://search.msn.com/results.asp?q="),
		};
public static SearchSpec[] getCommonSpecs() {
	return(commonSpecs);
}

public static String makeURL(String searchEngineName,String searchString) {
		SearchSpec[] searchSpecs = getCommonSpecs();
	String searchURL = null;
	for(int i=0; i<searchSpecs.length; i++) {
		SearchSpec spec = searchSpecs[i];
		if (spec.getName().equalsIgnoreCase(searchEngineName)) {
			searchURL = spec.makeURL(searchString);
			break;
		}
	}
	return(searchURL);
}

}
