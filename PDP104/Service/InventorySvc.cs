﻿using PDP104.Data;
using PDP104.ViewModel;
using PDP104.Models;

using System.Collections.Generic;
using System.Linq;
using PDP104.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace PDP104.Service
{
    public interface IInvetorySvc
    {
        List<InventoryViewModel> GetAllInventory();
        Task<InventoryItem> CreateInventoryItem(int inventoryId, string model);
        List<InventoryViewModel> GetInventoryItemsByInventoryId(int inventoryId);
        Task<InventoryItem> GetInventoryItemById(int inventoryItemId);
        Task<InventoryItem> UpdateInventoryItemQuantity(int inventoryItemId, int newQuantity);
        Task<(InventoryItem? item, string message)> AddInventoryItemQuantity(int inventoryId, string model);
    }

    public class InventorySvc : IInvetorySvc
    {
        protected ApplicationDbContext _context;
        public InventorySvc(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<InventoryViewModel> GetAllInventory()
        {
            return _context.StorageOrders
                .Where(order => order.StatusInventory == StatusInventory.Active // Lọc kho đang hoạt động
                             && order.StorageSpaces.Any(space => space.Status == StatusStorage.full) // Chỉ lấy đơn hàng có kho đầy
                             && (order.TypeOfGoods == TypeOfGoods.Container18ft
                                 || order.TypeOfGoods == TypeOfGoods.Container20ft
                                 || order.TypeOfGoods == TypeOfGoods.Container22ft) // Chỉ lấy đơn hàng có loại hàng là Container
                             && order.StatusOrder == StatusOrder.Imported) // Chỉ lấy đơn hàng đã nhập kho
                .OrderBy(order => order.DateOfEntry) // Sắp xếp theo ngày nhập kho tăng dần
                .Select(order => new InventoryViewModel
                {
                    StorageOrderId = order.Id,
                    RequestDate = order.Inventory.RequestDate,
                    StatusInventory = order.StatusInventory,
                    DateOfEntry = order.DateOfEntry,
                    DateOfShipment = order.DateOfShipment,
                })
                .ToList();
        }

        public List<InventoryViewModel> GetInventoryItemsByInventoryId(int inventoryId)
        {
            return _context.InventoryItems
                .Where(item => item.InventoryId == inventoryId) // Lọc theo InventoryId
                .OrderBy(item => item.Model) // Sắp xếp theo Model (tùy chỉnh nếu cần)
                .Select(item => new InventoryViewModel
                {
                    Model = item.Model,
                    Quantity = item.Quantity
                })
                .ToList();
        }

        public async Task<InventoryItem> CreateInventoryItem(int inventoryId, string model)
        {
            // Kiểm tra Inventory có tồn tại không
            var inventory = await _context.Inventories.FindAsync(inventoryId);
            if (inventory == null)
            {
                throw new Exception($"Inventory với ID {inventoryId} không tồn tại.");
            }

            // Kiểm tra xem InventoryItem với Model đã tồn tại trong Inventory chưa
            bool isModelExists = await _context.InventoryItems
                .AnyAsync(item => item.InventoryId == inventoryId && item.Model == model);

            if (isModelExists)
            {
                throw new Exception($"Model '{model}' đã tồn tại trong Inventory ID {inventoryId}.");
            }

            // Tạo InventoryItem mới
            var inventoryItem = new InventoryItem
            {
                InventoryId = inventoryId,
                Model = model,
            };

            _context.InventoryItems.Add(inventoryItem);
            await _context.SaveChangesAsync();

            return inventoryItem;
        }
        public async Task<InventoryItem> GetInventoryItemById(int inventoryItemId)
        {
            var inventoryItem = await _context.InventoryItems.FindAsync(inventoryItemId);
            if (inventoryItem == null)
            {
                throw new Exception($"InventoryItem với ID {inventoryItemId} không tồn tại.");
            }
            return inventoryItem;
        }

        // Cập nhật Quantity của InventoryItem
        public async Task<InventoryItem> UpdateInventoryItemQuantity(int inventoryItemId, int newQuantity)
        {
            var inventoryItem = await _context.InventoryItems.FindAsync(inventoryItemId);
            if (inventoryItem == null)
            {
                throw new Exception($"InventoryItem với ID {inventoryItemId} không tồn tại.");
            }

            // Cập nhật số lượng
            inventoryItem.Quantity = newQuantity;

            _context.InventoryItems.Update(inventoryItem);
            await _context.SaveChangesAsync();

            return inventoryItem;
        }
        public async Task<(InventoryItem? item, string message)> AddInventoryItemQuantity(int inventoryId, string model)
        {
            // Tìm InventoryItem theo InventoryId và Model
            var inventoryItem = await _context.InventoryItems
                .FirstOrDefaultAsync(item => item.InventoryId == inventoryId && item.Model == model);

            if (inventoryItem != null)
            {
                // Tăng số lượng lên 1
                inventoryItem.Quantity += 1;
                _context.InventoryItems.Update(inventoryItem);
                await _context.SaveChangesAsync();

                return (inventoryItem, $"Quantity của Model '{model}' đã được tăng lên {inventoryItem.Quantity}.");
            }
            else
            {
                // Trả về thông báo yêu cầu xác nhận thêm sản phẩm mới
                return (null, $"Model '{model}' không có trong danh sách kiểm kê. Bạn có muốn thêm mới không?");
            }
        }




    }
}

