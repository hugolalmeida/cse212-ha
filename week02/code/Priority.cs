public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine("Still Working on Dequeue Cases");

        // Test Cases

        // Test 1
        // Scenario: Add 4 itens(ring, 4),(necklace, 3), (watch, 4), (robe, 2) with being 2 of them with the same priority and then the folowing with differents prioritys then delete the highest priority in the queue
        // Expected Result: Ring, Necklace, Watch
        Console.WriteLine("Test 1");
        priorityQueue.Dequeue(); //Testing the empty queue message, I will delete this after
        priorityQueue.Enqueue("Ring", 4);
        priorityQueue.Enqueue("Necklace", 3);
        priorityQueue.Enqueue("Watch", 4);
        priorityQueue.Enqueue("Robe", 5);
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: The Dequeue is not working

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Delete from list the 2 itens with same higher priority
        // Expected Result:  Necklace
        Console.WriteLine("Test 2");
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: It is not removing both of the list

        Console.WriteLine("---------");


        // Test 3
        // Scenario: Delete the last iten
        // Expected Result:  [].
        Console.WriteLine("Test 3");
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: It is workin

        Console.WriteLine("---------");

        // Test 4
        // Scenario: Get the error message of empty queue
        // Expected Result:  The queue is empty. []
        Console.WriteLine("Test 4");
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: It is workin

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}