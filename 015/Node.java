public class Node {
	private Node right;
	private Node down;
	private String name;

	public Node() {
		right = null;
		down = null;
		name = "node";
	}

	public Node(Node right, Node down) {
		this.right = right;
		this.down = down;
	}

	public void setRight(Node right) {
		this.right = right;
	}

	public void setDown(Node down) {
		this.down = down;
	}

	public Node getRight() {
		return right;
	}

	public Node getDown() {
		return down;
	}
	
	public void setName(String name) {
		this.name = name;
	}
	
	public String getName() {
		return name;
	}

}
