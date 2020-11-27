public class main {
	public static void main(String[] args) {

		int size = 3;
		Node head = new Node();
		buildMatrix(head, size);
		
		System.out.println(count(head));
		
			
	}
	
	public static int count(Node n) {
		if(n.getRight() != null && n.getDown() != null) {
			return count(n.getRight()) + count(n.getDown());
		}
		
		if(n.getRight() != null) {
			return count(n.getRight());
		}
		
		if(n.getDown() != null) {
			return count(n.getDown());
		}
		
		if(n.getName().equals("end")) {
			return 1;
		}
		
		return 0;
	}
	
	

	public static void buildMatrix(Node head, int size) {
		size=size-1;
		Node pt = head;

		for (int i = 0; i <= size; i++) {
			
			Node pt2 = pt;
			for (int j = 0; j < size; j++) {
				pt2.setDown(new Node());
				pt2 = pt2.getDown();
				if(i == size && j == size-1) {
					pt2.setName("end");
				}
				
			}
			
			if(i != size) {
				pt.setRight(new Node());
				pt = pt.getRight();
			}
		}
		

//		pt = head;
//		Node pt2 = pt.getRight();
//
//		while(pt2 != null) {
//			Node pt3 = pt;
//			Node pt4 = pt2;
//			while(pt4 != null) {
//				pt3.setRight(pt4);
//				pt3 = pt3.getDown();
//				pt4 = pt4.getDown();
//			}
//			pt = pt.getRight();
//			pt2 = pt2.getRight();
//		}
	}
}
