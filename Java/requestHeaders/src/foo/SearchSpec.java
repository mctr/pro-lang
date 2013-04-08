package foo;

public class SearchSpec {
	private String name, baseURL;

	public SearchSpec(String name,String baseURL) {
		this.name = name;
		this.baseURL = baseURL;
	}
	public String makeURL(String searchString) {
		return(baseURL + searchString);
	}
	public String getName() {
		return(name);
	}
	
}
